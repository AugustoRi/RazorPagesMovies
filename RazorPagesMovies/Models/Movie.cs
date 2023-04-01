using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Título")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$]")]
        [Required(ErrorMessage = "Escreva o Gênero do Filme")]
        [MaxLength(100, ErrorMessage = "Nome muito extenso.")]
        [Display(Name = "Gênero")]
        public string Gender { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [Range(0, 10)]
        [Display(Name = "Nota de Avaliação")]
        public int Avaliation { get; set; } = 0;
    }
}
