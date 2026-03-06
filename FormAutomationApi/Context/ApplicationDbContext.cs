using FormAutomationApi.Model;
using Microsoft.EntityFrameworkCore;

namespace FormAutomationApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<DocumentType> DocumentTypes { get; set; }

        public DbSet<DocumentVersion> DocumentVersions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().ToTable("patient");

            modelBuilder.Entity<DocumentType>().ToTable("documenttype");

            modelBuilder.Entity<DocumentVersion>().ToTable("documentversion");
        }
    }
}
