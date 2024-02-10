using BookWareHouse.DTO.Enums;

namespace BookWareHouse.DTO.EntityViewSQL
{
	public class OrderView
	{
		public int Id { get; set; }
		public string Creator { get; }
		public string Borrowers { get; }
		public string BookName { get; }
		public DateTime ExpectedReturnDate { get;  }
		public DateTime ActualReturnDate { get; }
		public int Status { get; }
	}
}