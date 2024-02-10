using BookWareHouse.DTO.Shared;

namespace BookWareHouse.DTO.Entites
{
	public class Category : DomainEntity<int>
	{
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public List<Book> books { get; set; }
	}
}