using BookWareHouse.DTO.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntittyConfigurations
{
	public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.ToTable("Users");
			builder.HasIndex(x => x.UserName).IsUnique();
			builder.Property(x => x.FirstName).HasMaxLength(255);
			builder.Property(x => x.LastName).HasMaxLength(255);
			builder.Property(x => x.Address).HasMaxLength(255);
			builder.Property(x => x.CertificationCard).HasMaxLength(12);
		}
	}
}