using BookWareHouse.DTO.EntityViewSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWareHouse.DTO.Configurations.EntityViewSQLConfigurations
{
	public class UserViewConfiguration : IEntityTypeConfiguration<UserView>
	{
		public void Configure(EntityTypeBuilder<UserView> builder)
		{
			builder.HasNoKey().ToView("UserView");
			builder.Property(x => x.Id).HasColumnName("Id");
			builder.Property(x => x.FullName).HasColumnName("FullName");
			builder.Property(x => x.CertificationCard).HasColumnName("CertificationCard");
			builder.Property(x => x.Address).HasColumnName("Address");
			builder.Property(x => x.Email).HasColumnName("Email");
			builder.Property(x => x.PhoneNumber).HasColumnName("PhoneNumber");
			builder.Property(x => x.RoleName).HasColumnName("RoleName");
			builder.Property(x => x.FullName).HasColumnName("FullName");
		}
	}
}