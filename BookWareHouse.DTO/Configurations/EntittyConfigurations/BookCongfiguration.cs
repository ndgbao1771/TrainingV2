using BookWareHouse.DTO.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntittyConfigurations
{
	public class BookCongfiguration : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.ToTable("Books");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.BookName).HasMaxLength(255);
			builder.Property(x => x.Price).HasColumnType("decimal(10,0)");

			builder.HasMany(x => x.bookDetails).WithOne(x => x.book).HasForeignKey(x => x.BookId);
		}
	}
}