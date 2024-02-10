using BookWareHouse.DTO.Shared;

namespace BookWareHouse.DTO.Entites
{
	public class BookDetail : DomainEntity<int>
	{
		public string Seri { get; set; }
		public int BookId { get; set; }
		public Book book { get; set; }
	}
}