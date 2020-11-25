using Microsoft.EntityFrameworkCore;
using MovieCatalog.Database.Context.Base;
using MovieCatalog.Database.Help;
using MovieCatalog.Models;

namespace MovieCatalog.Database.Context
{
    public class Catalog : DbContext, IContext
    {
        public DbSet<Movie> Movies { get; set; }
        private readonly Auth _context;

        public Catalog(DbContextOptions<Catalog> options, Auth context) : base(options)
        {
            _context = context;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(Generate.GetFakeMovies(_context));
        }
    }
}
