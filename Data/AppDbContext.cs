using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMANpizza.Identity;
using VMANpizza.Models;
using VMANpizza.Models.ViewModel;

namespace VMANpizza.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("data source =.\\SQLEXPRESS01;Initial Catalog=VMANpizzaDb;Integrated Security=true;MultipleActiveResultSets=true;");
        //options.UseSqlServer("Server=tcp:tserving.database.windows.net,1433;Initial Catalog = Vlive; Persist Security Info=False;User ID = DBanger; Password=sdktesting@2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");

        
        public DbSet<Pizza> Pizzas { get; set; }
       
        public DbSet<VMANpizza.Models.ViewModel.OrderPizza> OrderPizza { get; set; }

    }
}

