using System.Collections.Generic;
using MovieCatalog.Models;

namespace MovieCatalog.Database.Base
{
    public interface IInteraction
    {       
        public int GetCount();
        public List<Movie> GetPaginatedMovies(int currentPage, int pageSize = 10);
        public Movie GetMovie(int movieId);
        public void DeleteMovie(int movieId);
        public void AddMovie(Movie movie);
        public void EditMovie(Movie movie);
    }
}
