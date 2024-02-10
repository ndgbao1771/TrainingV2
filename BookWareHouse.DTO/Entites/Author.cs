using BookWareHouse.DTO.Interfaces;
using BookWareHouse.DTO.Shared;

namespace BookWareHouse.DTO.Entites
{
	public class Author : DomainEntity<int>, IDateTracking
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime Birthday { get; set; }
		public DateTime CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public List<Book> books { get; set; }
	}
}