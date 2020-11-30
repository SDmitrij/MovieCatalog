using System.Collections.Generic;
using MovieCatalog.Models;

namespace MovieCatalog.Database.Base
{
    public interface IInteraction
    {       
        public int GetCount();
        public List<Movie> GetPaginatedMovies(int currentPage, int pageSize);
        public Movie GetMovie(int movieId);
        public void DeleteMovie(Movie movie);
        public void AddMovie(Movie movie);
        public void EditMovie(Movie movie);
    }
}
