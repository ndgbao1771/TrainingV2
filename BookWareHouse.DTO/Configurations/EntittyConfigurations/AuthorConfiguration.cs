using BookWareHouse.DTO.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntittyConfigurations
{
	public class AuthorConfiguration : IEntityTypeConfiguration<Author>
	{
		public void Configure(EntityTypeBuilder<Author> builder)
		{
			builder.ToTable("Authors");
			builder.HasKey(a => a.Id);
			builder.Property(x => x.FirstName).HasMaxLength(255);
			builder.Property(x => x.LastName).HasMaxLength(255);

			builder.HasMany(x => x.books).WithOne(x => x.author).HasForeignKey(x => x.AuthorId);
		}
	}
}