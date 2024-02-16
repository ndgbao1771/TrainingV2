using AutoMapper;
using BookWareHouse.DTO.Entites;
using BookWareHouse.Repository.Interfaces;
using BookWareHouse.Service.EntityDTO;
using BookWareHouse.Service.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BookWareHouse.Service.Services
{
	public class AppUserService : IAppUserService
	{
		#region Contructor

		private readonly IAppUserRepository _appUserRepository;
		private readonly IMapper _mapper;
		private readonly UserManager<AppUser> _userManager;

		public AppUserService(IAppUserRepository appUserRepository, IMapper mapper, UserManager<AppUser> userManager)
		{
			_appUserRepository = appUserRepository;
			_mapper = mapper;
			_userManager = userManager;
		}

		#endregion Contructor

		#region Method

		public async Task<AppUserDTO> Register(AppUserDTO model)
		{
			var datas = _mapper.Map<AppUserDTO, AppUser>(model);
			await _userManager.CreateAsync(datas, model.Password);
			return model;
		}

		#endregion Method
	}
}