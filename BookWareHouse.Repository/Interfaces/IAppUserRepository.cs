using BookWareHouse.DTO.Entites;
using BookWareHouse.Repository.Interfaces.Shared;

namespace BookWareHouse.Repository.Interfaces
{
	public interface IAppUserRepository 
	{
		IQueryable<AppUser> Register(AppUser model);
	}
}