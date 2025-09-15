using System.Collections.Generic;
using MovieLibrary.Models;

namespace MovieLibrary.Data
{
    public static class MockData
    {
        public static List<Movie> GetMockMovies()
        {
            return new List<Movie>
            {
                new Movie {
                    Title = "Inception",
                    Director = "Christopher Nolan",
                    Year = 2010,
                    Genre = "Sci-Fi / Thriller",
                    Description = "A thief who enters people's dreams to steal secrets.",
                    Duration = 148,
                    Rating = 8.8,
                    CoverImageUrl = "../Assets/Inception.jpg"
                },
                new Movie {
                    Title = "The Shawshank Redemption",
                    Director = "Frank Darabont",
                    Year = 1994,
                    Genre = "Drama",
                    Description = "Two imprisoned men bond over a number of years.",
                    Duration = 142,
                    Rating = 9.3,
                    CoverImageUrl = "../Assets/TheShawshankRedemption.jpg"
                },
                new Movie {
                    Title = "The Matrix",
                    Director = "The Wachowskis",
                    Year = 1999,
                    Genre = "Sci-Fi / Action",
                    Description = "A hacker learns about the true nature of his reality.",
                    Duration = 136,
                    Rating = 8.7,
                    CoverImageUrl = "../Assets/TheMatrix.jpg"
                }
            };
        }
    }
}
