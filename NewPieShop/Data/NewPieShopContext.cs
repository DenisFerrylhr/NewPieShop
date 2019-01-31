using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewPieShop.Models;

namespace NewPieShop.Models
{
    public class NewPieShopContext : DbContext
    {
        public NewPieShopContext (DbContextOptions<NewPieShopContext> options)
            : base(options)
        {
        }

        public DbSet<NewPieShop.Models.Customer> Customer { get; set; }

        public DbSet<NewPieShop.Models.Pie> Pie { get; set; }

        public DbSet<NewPieShop.Models.Purchase> Purchase { get; set; }
    }
}
