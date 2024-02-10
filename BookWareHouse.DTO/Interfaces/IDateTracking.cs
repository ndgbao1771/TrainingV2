namespace BookWareHouse.DTO.Interfaces
{
	public interface IDateTracking
	{
		DateTime CreatedAt { get; set; }
		string CreatedBy { get; set; }
		DateTime UpdatedAt { get; set; }
		string UpdatedBy { get; set; }
	}
}