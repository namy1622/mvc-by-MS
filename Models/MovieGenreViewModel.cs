using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Models;

namespace AppMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { set; get; }
        public SelectList? Genres { set; get; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
