using AutoMapper;
using BookWareHouse.DTO.Entites;
using BookWareHouse.Service.EntityDTO;

namespace BookWareHouse.Service.AutoMappers
{
	public class DomainToDTO : Profile
	{
		public DomainToDTO()
		{
			CreateMap<AppUser, AppUserDTO>();
		}
	}
}