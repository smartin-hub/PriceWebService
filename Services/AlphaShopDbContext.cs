
using Microsoft.EntityFrameworkCore;
using PriceWebService.Models;

namespace PriceWebService.Services
{
    public class AlphaShopDbContext : DbContext
    {
        public AlphaShopDbContext(DbContextOptions<AlphaShopDbContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Listini> Listini { get; set; }

        public virtual DbSet<DettListini> DettListini { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Listini>()
                .HasKey(a => new { a.Id });

            modelBuilder.Entity<DettListini>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<DettListini>()
                .HasOne<Listini>(s => s.listino) //ad un listino...
                .WithMany(g => g.DettListini) //corrispondono molti dettagli listino
                .HasForeignKey(s => s.IdList); //la chiave esterna dell'entity dettListini

         
        }
    }

}