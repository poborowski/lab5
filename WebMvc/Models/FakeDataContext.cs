using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;
using WebMvc.Controllers;

namespace WebMvc.Models
{
    public class FakeContext : DbContext
    {
        public FakeContext(DbContextOptions<FakeContext> options)
            : base(options)
        {
        }

        public DbSet<Todoitems> TodoItems { get; set; }

        public DbSet<WebApplication8.Models.Todoitems> TodoItem { get; set; }
    }
}
