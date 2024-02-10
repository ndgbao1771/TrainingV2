using BookWareHouse.DTO.EntityViewSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntityViewSQLConfigurations
{
	public class CategoryViewConfiguration : IEntityTypeConfiguration<CategoryView>
	{
		public void Configure(EntityTypeBuilder<CategoryView> builder)
		{
			builder.HasNoKey().ToView("CategoryView");
			builder.Property(x => x.Id).HasColumnName("Id");
			builder.Property(x => x.CategoryName).HasColumnName("CategoryName");
			builder.Property(x => x.Description).HasColumnName("Description");
		}
	}
}