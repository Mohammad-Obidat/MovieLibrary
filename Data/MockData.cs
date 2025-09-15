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
                },
                new Movie {
                    Title = "Interstellar",
                    Director = "Christopher Nolan",
                    Year = 2014,
                    Genre = "Sci-Fi / Adventure",
                    Description = "A team of explorers travel through a wormhole in space.",
                    Duration = 169,
                    Rating = 8.6,
                    CoverImageUrl = "../Assets/Interstellar.jpg"
                },
                new Movie {
                    Title = "Parasite",
                    Director = "Bong Joon-ho",
                    Year = 2019,
                    Genre = "Thriller / Drama",
                    Description = "Greed and class discrimination threaten a family's safety.",
                    Duration = 132,
                    Rating = 8.6,
                    CoverImageUrl = "../Assets/Parasite.jpg"
                },
                new Movie {
                    Title = "The Dark Knight",
                    Director = "Christopher Nolan",
                    Year = 2008,
                    Genre = "Action / Crime",
                    Description = "Batman faces the Joker, a criminal mastermind.",
                    Duration = 152,
                    Rating = 9.0,
                    CoverImageUrl = "../Assets/TheDarkKnight.jpg"
                },
                new Movie {
                    Title = "Gladiator",
                    Director = "Ridley Scott",
                    Year = 2000,
                    Genre = "Action / Drama",
                    Description = "A former Roman general seeks revenge against a corrupt emperor.",
                    Duration = 155,
                    Rating = 8.5,
                    CoverImageUrl = "../Assets/Gladiator.jpg"
                },
                new Movie {
                    Title = "Avatar",
                    Director = "James Cameron",
                    Year = 2009,
                    Genre = "Sci-Fi / Adventure",
                    Description = "A paraplegic Marine is sent to the alien world of Pandora.",
                    Duration = 162,
                    Rating = 7.8,
                    CoverImageUrl = "../Assets/Avatar.jpg"
                },
                new Movie {
                    Title = "The Godfather",
                    Director = "Francis Ford Coppola",
                    Year = 1972,
                    Genre = "Crime / Drama",
                    Description = "The aging patriarch of an organized crime dynasty transfers control to his son.",
                    Duration = 175,
                    Rating = 9.2,
                    CoverImageUrl = "../Assets/TheGodfather.jpg"
                },
                new Movie {
                    Title = "Titanic",
                    Director = "James Cameron",
                    Year = 1997,
                    Genre = "Romance / Drama",
                    Description = "A young couple falls in love aboard the ill-fated RMS Titanic.",
                    Duration = 195,
                    Rating = 7.8,
                    CoverImageUrl = "../Assets/Titanic.jpg"
                }
            };
        }
    }
}
