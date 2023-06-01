using Microsoft.EntityFrameworkCore;

namespace Uygulama_1.Models
{
    public class UygulamaContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// override on yazınca geliyor.
        {
            optionsBuilder.UseSqlServer("Server=EREN\\SQLEXPRESS;Database=Uygulama;Integrated Security=true");
        }
    }
}
