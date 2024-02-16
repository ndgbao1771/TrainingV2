using AutoMapper;
using BookWareHouse.DTO.Entites;
using BookWareHouse.Service.EntityDTO;

namespace BookWareHouse.Service.AutoMappers
{
	public class DTOToDomain : Profile
	{
		public DTOToDomain()
		{
			CreateMap<AppUserDTO, AppUser>();
		}
	}
}
