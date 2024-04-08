using C__EntityFrameworkConsole.Models;
using Microsoft.EntityFrameworkCore;


namespace C__EntityFrameworkConsole.Data
{
    internal class AppDbContext:DbContext
    {

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-M839BQT\\SQLEXPRESS;Database=EntityFrameworkPB101Db;Trusted_Connection=true;TrustServerCertificate=True");
        }
    }
}
