using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCatalog.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]      
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Produced date")]
        public DateTime ProducedDate { get; set; }

        [Required]
        public string Producer { get; set; }

        [BindProperty]
        [Display(Name = "Poster")]
        [NotMapped]
        [Required]
        public IFormFile PosterFile { get; set; }
        
        public string Poster { get; set; }

        public string UserId { get; set; }      
    }
}
