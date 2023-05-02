using Catstagram.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagram.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                //Post

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(new List<Post>()
                    {
                        new Post()
                        {
                            Image = "/images/catpic1.jpg",
                            AuthorName = "Lorem Ipsum",
                            AuthorEmail = "loremipsum@gmail.com",
                            Comments = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore." + "#Fluffy",
                            DateAdded = DateTime.UtcNow
                        },
                        new Post()
                        {
                            Image = "/images/catpic2.jpg",
                            AuthorName = "Lorem Ipsum2",
                            AuthorEmail = "loremipsum2@gmail.com",
                            Comments = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore." + "#Fluffy",
                            DateAdded = DateTime.UtcNow
                        },
                        new Post()
                        {
                            Image = "/images/catpic3.jpg",
                            AuthorName = "Lorem Ipsum2",
                            AuthorEmail = "loremipsum2@gmail.com",
                            Comments = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                            DateAdded = DateTime.UtcNow
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
