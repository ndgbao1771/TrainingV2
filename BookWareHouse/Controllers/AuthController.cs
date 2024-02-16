using BookWareHouse.DTO.Entites;
using BookWareHouse.Models;
using BookWareHouse.Service.EntityDTO;
using BookWareHouse.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookWareHouse.Controllers
{
	[ApiController]
	[Route("Auth")]
	public class AuthController : ControllerBase
	{
		private readonly SignInManager<AppUser> _signInManager;
		private readonly UserManager<AppUser> _userManager;
		private readonly IConfiguration _configuration;
		private readonly IAppUserService _appUserService;

		public AuthController(
			SignInManager<AppUser> signInManager,
			UserManager<AppUser> userManager,
			IConfiguration configuration,
			IAppUserService appUserService)
		{
			_signInManager = signInManager;
			_userManager = userManager;
			_configuration = configuration;
			_appUserService = appUserService;
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			// Authenticate user using SignInManager
			var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

			if (result.Succeeded)
			{
				// Generate JWT token
				var user = await _userManager.FindByNameAsync(model.UserName);
				var token = GenerateJwtToken(user);
				return Ok(new { Token = token });
			}

			return Unauthorized();
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Register(AppUserDTO model) 
		{
			if (!ModelState.IsValid)
			{
				_appUserService.Register(model);
				return Created();
			}
			return BadRequest("Add Failed");
		}

		private string GenerateJwtToken(AppUser user)
		{
			var claims = new List<Claim>
		{
			new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
			new Claim(ClaimTypes.Name, user.UserName),
			new Claim(ClaimTypes.Role, "Admin"),
			new Claim(ClaimTypes.Role, "Librarian"),
			new Claim(ClaimTypes.Role, "Member"),
            // Add more claims as needed
        };

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
			var expires = DateTime.Now.AddHours(Convert.ToDouble(_configuration["JWT:ExpireHours"]));

			var token = new JwtSecurityToken(
				_configuration["JWT:ValidAudience"],
				_configuration["JWT:ValidIssuer"],
				claims,
				expires: expires,
				signingCredentials: creds
			);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
