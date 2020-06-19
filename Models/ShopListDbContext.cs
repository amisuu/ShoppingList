using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class ShopListDbContext : DbContext
    {
        public ShopListDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ShopItemModel> ShopItemList { get; set; }
    }
}
