using ASP.NET_TEST.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_TEST.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
       {

       }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry {
                    ID = 1,
                    Title = "Went Hiking",
                    Content = "Went Hiking with Denis",
                    Created = DateTime.Today
                },

                new DiaryEntry
                {
                    ID = 2,
                    Title = "Went Hiking",
                    Content = "Went Hiking with Alisson",
                    Created = DateTime.Today
                },

                new DiaryEntry
                {
                    ID = 3,
                    Title = "Went Biking",
                    Content = "Went Biking with Alisson",
                    Created = DateTime.Today
                }
            );
        }
    }
}
