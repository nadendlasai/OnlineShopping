
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Shopping.Entities;
using OnlineShopping.Shopping.Mappings;

namespace OnlineShopping.Shopping.Context
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
        {
            
        }

        public DbSet<UsersEntity> usersEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersMapping());
        }
    }
}
