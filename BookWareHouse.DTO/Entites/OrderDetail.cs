using BookWareHouse.DTO.Shared;

namespace BookWareHouse.DTO.Entites
{
	public class OrderDetail : DomainEntity<int>
	{
		public DateTime ExpectedReturnDate { get; set; }
		public DateTime ActualReturnDate { get; set; }
		public int UserId { get; set; }
		public AppUser appUser { get; set; }
		public int OrderId { get; set; }
		public Order order { get; set; }
		public int BookId { get; set; }
		public Book book { get; set; }
	}
}