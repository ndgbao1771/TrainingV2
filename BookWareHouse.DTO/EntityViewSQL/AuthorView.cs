namespace BookWareHouse.DTO.EntityViewSQL
{
	public class AuthorView
	{
		public string Id { get; set; }
		public string FullName { get; set; }
		public DateTime Birthday { get; set; }
		public DateTime CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
	}
}