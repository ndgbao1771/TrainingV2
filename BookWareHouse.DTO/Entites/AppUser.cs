using BookWareHouse.DTO.Enums;
using Microsoft.AspNetCore.Identity;

namespace BookWareHouse.DTO.Entites
{
	public class AppUser : IdentityUser<int>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string CertificationCard { get; set; }
		public Sex Gender { get; set; }
		public List<Order> orders { get; set; }
	}
}