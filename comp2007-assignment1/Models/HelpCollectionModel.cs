namespace comp2007_assignment1.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class HelpCollectionModel : DbContext
	{
		public HelpCollectionModel()
			: base("name=DefaultConnection")
		{
		}

		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Project> Projects { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.Property(e => e.ProductName)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.ProductDescription)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.ImageURL)
				.IsUnicode(false);

			modelBuilder.Entity<Project>()
				.Property(e => e.ProjectName)
				.IsUnicode(false);

			modelBuilder.Entity<Project>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<Project>()
				.Property(e => e.ProjectLead)
				.IsUnicode(false);

			modelBuilder.Entity<Project>()
				.HasMany(e => e.Products)
				.WithRequired(e => e.Project)
				.WillCascadeOnDelete(false);
		}
	}
}
