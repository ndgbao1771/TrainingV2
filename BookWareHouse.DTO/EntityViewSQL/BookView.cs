namespace BookWareHouse.DTO.EntityViewSQL
{
	public class BookView
	{
		public int Id { get; set; }
		public string BookName { get; }
		public string AuthorName { get; }
		public string BookSeri { get; }
		public decimal Price { get; set; }
		public string Category { get; }
	}
}