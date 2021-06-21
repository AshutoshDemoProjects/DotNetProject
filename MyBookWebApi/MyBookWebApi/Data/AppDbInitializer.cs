using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyBookWebApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookWebApi.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Book.Any())
                {
                    context.Book.AddRange(new Book()
                    {
                        Title = "1st Book Title",
                        Discription = "1st Book Discription",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        CoverUrl="https....",
                        DateAdded=DateTime.Now
                    },
                    new Book()
                    {
                        Title = "2nd Book Title",
                        Discription = "2nd Book Discription",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now
                    }
                    );

                    context.SaveChanges();
                }
            }
        }
    }
}
