using MovieAPI.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="The field {0} is required")]
        [StringLength(50)]
        [FirstLetterUppercase]
        public string Name { get; set; }
    }
}
