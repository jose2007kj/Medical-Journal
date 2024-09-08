using Microsoft.EntityFrameworkCore;
using MedicalJournal.Models;
namespace MedicalJournal.Data;
public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Category>().HasData(
                    new Category { Id=2, Name="Action", DisplayOrder=1 },
                    new Category { Id=3, Name="Scifi", DisplayOrder=2 },
                    new Category { Id=4, Name="History", DisplayOrder=3 }
            );
        }
    }
