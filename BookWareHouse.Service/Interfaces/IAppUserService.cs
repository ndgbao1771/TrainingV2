using BookWareHouse.Service.EntityDTO;

namespace BookWareHouse.Service.Interfaces
{
	public interface IAppUserService
	{
		Task<AppUserDTO> Register(AppUserDTO model);
	}
}