using BookWareHouse.DTO.EntityViewSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntityViewSQLConfigurations
{
	public class AuthorViewConfiguration : IEntityTypeConfiguration<AuthorView>
	{
		public void Configure(EntityTypeBuilder<AuthorView> builder)
		{
			builder.HasNoKey().ToView("AuthorView");
			builder.Property(x => x.Id).HasColumnName("Id");
			builder.Property(x => x.FullName).HasColumnName("FullName");
			builder.Property(x => x.Birthday).HasColumnName("Birthday");
			builder.Property(x => x.CreatedAt).HasColumnName("CreatedAt");
			builder.Property(x => x.CreatedBy).HasColumnName("CreatedBy");
			builder.Property(x => x.UpdatedAt).HasColumnName("UpdatedAt");
			builder.Property(x => x.UpdatedBy).HasColumnName("UpdatedBy");
		}
	}
}