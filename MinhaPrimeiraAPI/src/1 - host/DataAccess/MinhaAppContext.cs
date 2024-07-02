using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.Domain;

namespace MinhaPrimeiraAPI.DataAccess
{
    public class MinhaAppContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public MinhaAppContext(DbContextOptions<MinhaAppContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           MapPlayer(modelBuilder);
        }

        void MapPlayer(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Player>()
            //    .ToTable("player")
            //     .HasKey(p => p.PlayerId).HasName("id");

            //modelBuilder.Entity<Player>()
            //    .Property(p => p.Name)
            //    .HasColumnName("player_name");
        }

    }

}
