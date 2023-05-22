using CerealsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CerealsApi.Db
{
    public class CerealsDbContext : DbContext
    {
        public DbSet<Cereal> Cereals { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // ajouter la ligne suivante
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_cereals");
        }

    }
}
