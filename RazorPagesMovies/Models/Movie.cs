using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
        public string Gender { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
