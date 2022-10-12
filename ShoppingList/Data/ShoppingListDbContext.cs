using Microsoft.EntityFrameworkCore;
using ShoppingList.Models;

namespace ShoppingList.Data
{
    public class ShoppingListDbContext:DbContext
    {
        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemHistory> ItemHistories { get; set; }
        public DbSet<ListItem> ListItems { get; set; }
        public DbSet<Lista> Lists { get; set; }
    }
}
