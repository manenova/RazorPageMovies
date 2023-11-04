using Microsoft.EntityFrameworkCore;
using RazorPageMovies.Data;


namespace RazorPageMovies.Models
{
    public static class SpeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPageMoviesContext>>()))
            {
                if (context == null | context.Movie == null)
                {
                    throw new ArgumentNullException("Null Razor PagerMoviesContext");

                }

                if (context.Movie.Any())
                {
                    return;
                    
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry met Sally",
                        RealseDate = DateTime.Parse("1989-2-12"),  
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating  = "G",
                    },
                      new Movie
                      {
                          Title = "Ghostbusters",
                          RealseDate = DateTime.Parse("1984-3-13"),
                          Genre = "Comedy",
                          Price = 8.99M,
                          Rating = "G",
                      },
                        new Movie
                        {
                            Title = "Ghostbusters 2",
                            RealseDate = DateTime.Parse("1984-3-13"),
                            Genre = "Comedy",
                            Price = 9.99M,
                            Rating = "G",
                        },
                        new Movie
                        {
                            Title = "Rio Bravo",
                            RealseDate = DateTime.Parse("1959-4-15"),
                            Genre = "Western",
                            Price = 3.99M,
                            Rating = "G",
                        }
                );

                context.SaveChanges();

            }
        }
    }
}
