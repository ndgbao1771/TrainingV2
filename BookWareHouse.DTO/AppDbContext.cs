using BookWareHouse.DTO.Configurations.EntittyConfigurations;
using BookWareHouse.DTO.Configurations.EntityViewSQLConfigurations;
using BookWareHouse.DTO.Entites;
using BookWareHouse.DTO.EntityViewSQL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookWareHouse.DTO
{
	public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region Identity Config

			modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("AppUserClaims").HasKey(x => x.Id);

			modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("AppRoleClaims")
				.HasKey(x => x.Id);

			modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

			modelBuilder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles")
				.HasKey(x => new { x.RoleId, x.UserId });

			modelBuilder.Entity<IdentityUserToken<string>>().ToTable("AppUserTokens")
			   .HasKey(x => new { x.UserId });

			#endregion Identity Config

			#region Register Entity

			modelBuilder.ApplyConfiguration(new AppUserConfiguration());
			modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
			modelBuilder.ApplyConfiguration(new AuthorConfiguration());
			modelBuilder.ApplyConfiguration(new BookCongfiguration());
			modelBuilder.ApplyConfiguration(new BookDetailConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfiguration(new OrderConfiguration());
			modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

			#endregion Register Entity

			#region Register Entity ViewSQL

			modelBuilder.ApplyConfiguration(new UserViewConfiguration());
			modelBuilder.ApplyConfiguration(new AuthorViewConfiguration());
			modelBuilder.ApplyConfiguration(new BookViewConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryViewConfiguration());
			modelBuilder.ApplyConfiguration(new OrderViewConfiguration());

			#endregion Register Entity ViewSQL

			base.OnModelCreating(modelBuilder);

			// Bỏ tiền tố AspNet của các bảng: mặc định
			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				var tableName = entityType.GetTableName();
				if (tableName.StartsWith("AspNet"))
				{
					entityType.SetTableName(tableName.Substring(6));
				}
			}
		}

		#region Register DbSet<> Entities

		public DbSet<AppUser> appUsers { get; set; }
		public DbSet<AppRole> appRoles { get; set; }
		public DbSet<Author> authors { get; set; }
		public DbSet<Book> books { get; set; }
		public DbSet<BookDetail> bookDetails { get; set; }
		public DbSet<Category> categories { get; set; }
		public DbSet<Order> orders { get; set; }
		public DbSet<OrderDetail> orderDetails { get; set; }

		#endregion Register DbSet<> Entities

		#region Register DbSet<> EntityViewSQL

		public DbSet<UserView> users { get; set; }
		public DbSet<AuthorView> authorViews { get; set; }
		public DbSet<BookView> bookViews { get; set; }
		public DbSet<CategoryView> categoryViews { get; set; }
		public DbSet<OrderView> orderViews { get; set; }

		#endregion Register DbSet<> EntityViewSQL
	}
}