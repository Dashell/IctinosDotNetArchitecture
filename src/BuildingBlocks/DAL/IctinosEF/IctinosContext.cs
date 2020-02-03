using IctinosEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace IctinosEF
{
    public class IctinosContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public IctinosContext(DbContextOptions<IctinosContext> options)
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
              : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.UseSerialColumns();

            modelBuilder.Entity<Wallet>();
            modelBuilder.Entity<Coin>();
            modelBuilder.Entity<User>();
        }

        public DbSet<Coin> Coins { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
