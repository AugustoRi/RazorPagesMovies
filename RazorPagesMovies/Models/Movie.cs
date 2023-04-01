using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Display(Name = "Título")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
        [Display(Name = "Gênero")]
        public string Gender { get; set; } = string.Empty;
        [Display(Name = "Preço")]
        public decimal Price { get; set; }
    }
}
