using MovieCatalog.Database.Context;
using MovieCatalog.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieCatalog.Database.Help
{
    public static class Generate
    {
        public static IEnumerable<Movie> GetFakeMovies(Auth context)
        {
            var faker = new Bogus.Faker<Movie>("en");
            var userId = context.Users.FirstOrDefault().Id;

            faker.StrictMode(false)
                .RuleFor(m => m.Name, m => m.Lorem.Slug())
                .RuleFor(m => m.Description, m => m.Lorem.Text())
                .RuleFor(m => m.ProducedDate, m => m.Date.Past())
                .RuleFor(m => m.Producer, m => string.Format("{0} {1}", m.Name.LastName(), m.Name.FirstName()))
                .RuleFor(m => m.Poster, m => m.Image.PicsumUrl());

            var movies = faker.Generate(50); int movieId = 1;
            foreach (var movie in movies)
            {
                movie.Id = movieId;
                movie.UserId = userId;
                movieId++;
            }

            return movies;
        }
    }
}
