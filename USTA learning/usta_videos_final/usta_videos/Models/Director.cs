using System.ComponentModel.DataAnnotations;

namespace usta_videos.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Full name length must be between 3 and 40", MinimumLength = 1)]
        [Display(Name = "Full name")]
        public string Fullname { get; set; }

        [Required]
        [Display(Name = "Biography")]
        public string Bio {  get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }


    }
}
