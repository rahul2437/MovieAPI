using MovieAPI.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieAPI.DTOs
{
    public class GenreCreationDTO
    {
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50)]
        [FirstLetterUppercase]
        public string Name { get; set; }
    }
}
