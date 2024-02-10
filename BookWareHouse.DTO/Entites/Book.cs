using BookWareHouse.DTO.Interfaces;
using BookWareHouse.DTO.Shared;

namespace BookWareHouse.DTO.Entites
{
	public class Book : DomainEntity<int>, IDateTracking
	{
		public string BookName { get; set; }
		public decimal Price { get; set; }
		public DateTime CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public int AuthorId { get; set; }
		public Author author { get; set; }
		public int CategoryId { get; set; }
		public Category category { get; set; }
		public List<BookDetail> bookDetails { get; set; }
	}
}