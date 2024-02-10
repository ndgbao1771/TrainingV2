using BookWareHouse.DTO.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntittyConfigurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.ToTable("Categories");
			builder.HasKey(c => c.Id);

			builder.HasMany(x => x.books).WithOne(x => x.category).HasForeignKey(x => x.CategoryId);
		}
	}
}