using BookWareHouse.DTO.Entites;
using Microsoft.AspNetCore.Identity;
using System.Net;

namespace BookWareHouse.DTO
{
	public class DbInitializer
	{
		private readonly AppDbContext _context;
		private UserManager<AppUser> _userManager;
		private RoleManager<AppRole> _roleManager;

		public DbInitializer(AppDbContext context, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
		{
			_context = context;
			_userManager = userManager;
			_roleManager = roleManager;
		}

		public async Task Seed()
		{
			if (!_roleManager.Roles.Any())
			{
				await _roleManager.CreateAsync(new AppRole()
				{
					Name = "Admin",
					NormalizedName = "Admin",
					Description = "Top manager"
				});
				await _roleManager.CreateAsync(new AppRole()
				{
					Name = "Librarian",
					NormalizedName = "Library manager",
					Description = "Library manager"
				});
				await _roleManager.CreateAsync(new AppRole()
				{
					Name = "Member",
					NormalizedName = "Member",
					Description = "Member"
				});
			}
			if (!_userManager.Users.Any())
			{
				var a = await _userManager.CreateAsync(new AppUser()
				{
					UserName = "admin",
					FirstName = "Nguyen Van",
					LastName = "Admin",
					CertificationCard = "012345678912",
					Address = "Can Tho",
					Email = "admin@gmail.com",
					PhoneNumber = "0939796548",
					EmailConfirmed = true,
					PhoneNumberConfirmed = true,
				}, "123456");
				var user = await _userManager.FindByNameAsync("admin");
				await _userManager.AddToRoleAsync(user, "Admin");
			}
		}
	}
}