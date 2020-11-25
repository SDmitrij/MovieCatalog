using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieCatalog.Database.Base;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MovieCatalog.Pages.Movie
{
    public class MovieModel : PageModel
    {
        [BindProperty]
        public Models.Movie Movie { get; set; }
        
        public MovieModel(IInteraction interaction, IHttpContextAccessor httpContext, IWebHostEnvironment environment)
        {
            _interaction = interaction;
            _httpContext = httpContext;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            if (!User.Identity.IsAuthenticated) return new BadRequestResult();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!User.Identity.IsAuthenticated) return new BadRequestResult();
            if (!ModelState.IsValid) return Page();

            using (var fileStream = new FileStream(Path
                .Combine(_environment.ContentRootPath, "wwwroot", "uploads", Movie.PosterFile.FileName),
                FileMode.Create))
            {
                Movie.PosterFile.CopyTo(fileStream);
            }

            Movie.UserId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Movie.Poster = Movie.PosterFile.FileName;

            _interaction.AddMovie(Movie);

            return RedirectToPage("../Index");
        }

        public IActionResult OnGetInfo(int movieId)
        {
            ViewData["ContentRoot"] = Path.Combine(_environment.ContentRootPath, "wwwroot", "uploads");
            return new PartialViewResult
            {
                ViewName = "./_Partial/_MovieInfo",
                ViewData = new ViewDataDictionary<Models.Movie>(ViewData, _interaction.GetMovie(movieId))
            };
        }

        public IActionResult OnGetEditMovie(int movieId)
        {
            if (!User.Identity.IsAuthenticated) return new BadRequestResult();
            return new PartialViewResult
            {
                ViewName = "./_Partial/_EditMovie",
                ViewData = new ViewDataDictionary<Models.Movie>(ViewData, _interaction.GetMovie(movieId))
            };
        }

        public IActionResult OnPostEditMovie(Models.Movie movie)
        {
            if (!User.Identity.IsAuthenticated) return new BadRequestResult();
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
            if (!User.Identity.IsAuthenticated) return new BadRequestResult();
            return new PartialViewResult
            {
                ViewName = "./_Partial/_DeleteMovie"
            };
        }

        public IActionResult OnPostDeleteMovie(int movieId)
        {
            if (!User.Identity.IsAuthenticated) return new BadRequestResult();
            _interaction.DeleteMovie(movieId);
            return new OkResult();
        }
        #region private
        private readonly IInteraction _interaction;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IWebHostEnvironment _environment;
        #endregion
    }
}
