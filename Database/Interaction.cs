using MovieCatalog.Database.Base;
using MovieCatalog.Database.Context;
using MovieCatalog.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieCatalog.Database
{
    public class Interaction : IInteraction
    {
        public Interaction(Catalog catalogContext)
        {
            _catalogContext = catalogContext;
        }

        public List<Movie> GetPaginatedMovies(int currentPage, int pageSize = 10)
        {
            return GetMovies().OrderBy(m => m.Id)
                .Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public int GetCount()
        {
            return GetMovies().Count();
        }

        public Movie GetMovie(int movieId)
        {
            return _catalogContext.Movies.Find(movieId);
        }

        public void EditMovie(Movie movie)
        {
            _catalogContext.Movies.Update(movie);
            _catalogContext.SaveChanges();
        }

        public void DeleteMovie(int movieId)
        {
            var movie = GetMovie(movieId);
            if (movie is null) return;
            _catalogContext.Movies.Remove(movie);
            _catalogContext.SaveChanges();
        }

        public void AddMovie(Movie movie)
        {      
            _catalogContext.Add(movie);
            _catalogContext.SaveChanges();
        }

        #region private
        private List<Movie> GetMovies()
        {
            return _catalogContext.Movies.ToList();
        }

        private readonly Catalog _catalogContext;
        #endregion
    }
}
