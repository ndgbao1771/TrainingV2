using Microsoft.AspNetCore.Identity;

namespace BookWareHouse.DTO.Entites
{
	public class AppRole : IdentityRole<int>
	{
		public string Description { get; set; }
	}
}