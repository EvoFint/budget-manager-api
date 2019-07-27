using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetManagerAPI.Models.Repo;
using Microsoft.EntityFrameworkCore;

namespace BudgetManagerAPI.Controllers
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=BudgetApp;Username=postgres;Password=lama8146");
        }
    }
}
