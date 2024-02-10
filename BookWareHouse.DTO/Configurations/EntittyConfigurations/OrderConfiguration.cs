using BookWareHouse.DTO.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntittyConfigurations
{
	public class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.ToTable("Orders");
			builder.HasKey(x => x.Id);
			builder.HasMany(x => x.orderDetails).WithOne(x => x.order).HasForeignKey(x => x.OrderId).OnDelete(DeleteBehavior.Restrict);
		}
	}
}