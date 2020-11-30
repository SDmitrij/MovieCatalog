using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieCatalog.Database.Base;

namespace MovieCatalog.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int Count { get; set; }
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;
        public List<Models.Movie> Movies { get; set; }

        public IndexModel(IInteraction interaction)
        {
            _interaction = interaction;
        }

        public void OnGet()
        {
            Movies = _interaction.GetPaginatedMovies(CurrentPage, PageSize);
            Count = _interaction.GetCount();              
        }

        #region private
        private readonly IInteraction _interaction;
        #endregion
    }
}
