using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;
namespace WebApplication8.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TodoContext>>()))
            {
                // Look for any movies.
                if (context.TodoItems.Any())
                {
                    return;   // DB has been seeded
                }
                context.TodoItems.AddRange(
                    new Todoitems
                    {
                        Title = "W pustyni i w puszczy",
                        ReleaseDate = DateTime.Parse("1979-2-12"),
                        Category = "Przygodowe",
                        Price = 30M
                    },
                    new Todoitems
                    {
                        Title = "Harry Poter ",
                        ReleaseDate = DateTime.Parse("2007-3-13"),
                        Category = "Fantasy",
                        Price = 23M
                    },
                    new Todoitems
                    {
                        Title = "Pan Taduesz",
                        ReleaseDate = DateTime.Parse("1886-2-23"),
                        Category = "Poezja epicka",
                        Price = 15M
                    },
                    new Todoitems
                    {
                        Title = "Wesele",
                        ReleaseDate = DateTime.Parse("1859-4-15"),
                        Category = "Dramat",
                        Price = 12M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}