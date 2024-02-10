using BookWareHouse.DTO.Enums;
using BookWareHouse.DTO.Interfaces;
using BookWareHouse.DTO.Shared;

namespace BookWareHouse.DTO.Entites
{
	public class Order : DomainEntity<int>, IDateTracking
	{
		public StatusAble Status {  get; set; }
		public DateTime CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
		public int UserId { get; set; }
		public AppUser appUsers { get; set; }
		public List<OrderDetail> orderDetails { get; set; }
	}
}