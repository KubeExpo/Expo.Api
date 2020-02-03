using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Expo.Api
{
    public class ExpoEntityContext : DbContext
    {
        public ExpoEntityContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.BirthDate).IsRequired();
            });
        }
    }
}