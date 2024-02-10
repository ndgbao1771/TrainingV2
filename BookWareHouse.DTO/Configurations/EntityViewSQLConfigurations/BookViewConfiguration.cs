using BookWareHouse.DTO.EntityViewSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntityViewSQLConfigurations
{
	public class BookViewConfiguration : IEntityTypeConfiguration<BookView>
	{
		public void Configure(EntityTypeBuilder<BookView> builder)
		{
			builder.HasNoKey().ToView("BookView");
			builder.Property(x => x.Id).HasColumnName("Id");
			builder.Property(x => x.BookName).HasColumnName("BookName");
			builder.Property(x => x.AuthorName).HasColumnName("AuthorName");
			builder.Property(x => x.BookSeri).HasColumnName("BookSeri");
			builder.Property(x => x.Price).HasColumnType("decimal(10,0)").HasColumnName("Price");
			builder.Property(x => x.Category).HasColumnName("Category");
		}
	}
}