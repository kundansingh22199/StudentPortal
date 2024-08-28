using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        { 

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employes { get; set; }
        public DbSet<Appmst> appmst { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appmst>().ToTable("Tbl_Appmst");
            base.OnModelCreating(modelBuilder);
        }
    }
}
