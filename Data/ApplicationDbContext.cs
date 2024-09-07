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
    }
