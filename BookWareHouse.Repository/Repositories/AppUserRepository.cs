using BookWareHouse.DTO;
using BookWareHouse.DTO.Entites;
using BookWareHouse.Repository.Interfaces;

namespace BookWareHouse.Repository.Repositories
{
	public class AppUserRepository : IAppUserRepository
	{
		private readonly AppDbContext _context;

		public AppUserRepository(AppDbContext context)
		{
			_context = context;
		}

		public IQueryable<AppUser> Register(AppUser model)
		{
			return _context.appUsers.AsQueryable();
		}
	}
}