using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace usta_videos.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Logo")]
        public string Logo { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name length must be between 1 and 50", MinimumLength = 1)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Full name length must be between 1 and 100", MinimumLength = 1)]
        [Display(Name = "Description")]
        public string Desciption {  get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
