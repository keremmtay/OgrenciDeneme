using Microsoft.EntityFrameworkCore;

namespace SertifikaSinavi1.Models
{
    public class Model1 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ASUS;Database=SertifikaSinavi1;Integrated Security=true");
        }

        public virtual DbSet<Ogrenci> MyEntities { get; set; }

    }
}
