using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.DataBaseContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option) 
        { 
        }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
