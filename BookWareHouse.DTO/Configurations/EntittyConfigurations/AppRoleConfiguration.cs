using BookWareHouse.DTO.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntittyConfigurations
{
	public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			builder.ToTable("Roles");
			builder.Property(x => x.Description).HasMaxLength(255);
		}
	}
}