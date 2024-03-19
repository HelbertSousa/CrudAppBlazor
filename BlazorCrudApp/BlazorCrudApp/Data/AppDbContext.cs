using BlazorCrudApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
    }
}
