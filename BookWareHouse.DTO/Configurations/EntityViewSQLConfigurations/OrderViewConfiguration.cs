using BookWareHouse.DTO.EntityViewSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntityViewSQLConfigurations
{
	public class OrderViewConfiguration : IEntityTypeConfiguration<OrderView>
	{
		public void Configure(EntityTypeBuilder<OrderView> builder)
		{
			builder.HasNoKey().ToView("OrderView");
			builder.Property(x => x.Id).HasColumnName("Id");
			builder.Property(x => x.Creator).HasColumnName("Creator");
			builder.Property(x => x.Borrowers).HasColumnName("Borrowers");
			builder.Property(x => x.BookName).HasColumnName("BookName");
			builder.Property(x => x.ExpectedReturnDate).HasColumnName("ExpectedReturnDate");
			builder.Property(x => x.ActualReturnDate).HasColumnName("ActualReturnDate");
			builder.Property(x => x.Status).HasColumnName("Status");
		}
	}
}