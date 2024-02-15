using BookWareHouse.DTO;
using BookWareHouse.DTO.Shared;
using BookWareHouse.Repository.Interfaces.Shared;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookWareHouse.Repository.Repositories.Shared
{
	public class Repository<T, K> : IRepository<T, K> where T : DomainEntity<K>
	{
		private readonly AppDbContext _context;

		public Repository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(T entity)
		{
			_context.Add(entity);
		}

		public IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> items = _context.Set<T>();
			if (includeProperties != null)
			{
				foreach (var includeProperty in includeProperties)
				{
					items = items.Include(includeProperty);
				}
			}
			return items;
		}

		public IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> items = _context.Set<T>();
			if (includeProperties != null)
			{
				foreach (var includeProperty in includeProperties)
				{
					items = items.Include(includeProperty);
				}
			}
			return items.Where(predicate);
		}

		public T FindById(K id, params Expression<Func<T, object>>[] includeProperties)
		{
			return FindAll(includeProperties).SingleOrDefault(x => x.Id.Equals(id));
		}

		public T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
		{
			return FindAll(includeProperties).SingleOrDefault(predicate);
		}

		public void Remove(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

		public void Remove(K id)
		{
			Remove(FindById(id));
		}

		public void RemoveMultiple(List<T> entities)
		{
			_context.Set<T>().RemoveRange(entities);
		}

		public void Updated(T entity)
		{
			_context.Set<T>().Update(entity);
		}

		public void Commit()
		{
			_context.SaveChanges();
		}
	}
}