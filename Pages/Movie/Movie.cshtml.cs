using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieCatalog.Database.Base;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;

namespace MovieCatalog.Pages.Movie
{
    public class MovieModel : PageModel
    {
        [BindProperty]
        public Models.Movie Movie { get; set; }
        
        public MovieModel(IInteraction interaction, IHttpContextAccessor httpContext, 
            IWebHostEnvironment environment)
        {
            _interaction = interaction;
            _httpContext = httpContext;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            if (!User.Identity.IsAuthenticated) return BadRequest();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!User.Identity.IsAuthenticated) return BadRequest();
            if (!ModelState.IsValid) return Page();
            
            var uniqueFileName = string.Format("{0}{1}",
                Guid.NewGuid().ToString(), Movie.PosterFile.FileName);

            using (var fileStream = new FileStream(Path
                .Combine(_environment.ContentRootPath, "wwwroot", "uploads", uniqueFileName),
                FileMode.Create))
            {
                Movie.PosterFile.CopyTo(fileStream);
            }

            Movie.UserId = UserId;
            Movie.Poster = uniqueFileName;

            _interaction.AddMovie(Movie);

            return RedirectToPage("../Index");
        }

        public IActionResult OnGetInfo(int movieId)
        {         
            var movie = _interaction.GetMovie(movieId);
            if (movie is null) return NotFound();

            return new PartialViewResult
            {
                ViewName = "./_Partial/_MovieInfo",
                ViewData = new ViewDataDictionary<Models.Movie>(ViewData, movie)
            };
        }

        public IActionResult OnGetEditMovie(int movieId)
        {
            if (!User.Identity.IsAuthenticated) return BadRequest();
            var movie = _interaction.GetMovie(movieId);

            if (movie is null) return NotFound();

            return new PartialViewResult
            {
                ViewName = "./_Partial/_EditMovie",
                ViewData = new ViewDataDictionary<Models.Movie>(ViewData, movie)
            };
        }

        public IActionResult OnPostEditMovie(Models.Movie movie)
        {
            if (!User.Identity.IsAuthenticated) return BadRequest();
            if (UserId != movie.UserId) return BadRequest();

            if (ModelState.IsValid)
            {
                _interaction.EditMovie(movie);
            }

            return new PartialViewResult
            {
                ViewName = "./_Partial/_EditMovie",
                ViewData = new ViewDataDictionary<Models.Movie>(ViewData, movie)
            };
        }

        public IActionResult OnGetDeleteMovie()
        {
            if (!User.Identity.IsAuthenticated) return BadRequest();
            return new PartialViewResult
            {
                ViewName = "./_Partial/_DeleteMovie"
            };
        }

        public IActionResult OnPostDeleteMovie(int movieId)
        {
            if (!User.Identity.IsAuthenticated) return BadRequest();

            var movie = _interaction.GetMovie(movieId);

            if (movie is null) return NotFound();
            if (UserId != movie.UserId) return BadRequest();

            _interaction.DeleteMovie(movie);
            return new OkResult();
        }
        #region private
        private readonly IInteraction _interaction;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IWebHostEnvironment _environment;
        private string UserId => _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)
            .Value;
        #endregion
    }
}
