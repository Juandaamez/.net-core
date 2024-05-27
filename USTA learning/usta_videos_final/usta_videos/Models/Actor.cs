using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace usta_videos.Models
{
    public class Actor
    {
        [Key]

        
        public int Id { get; set; }

        [Required]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Full name length must be between 1 and 40", MinimumLength =1)]
        [Display(Name = "Full name")]
        public string Fullname { get; set; }

        [Required]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //relationships

        public List<Actor_Movie> Actor_Movie { get; set; }
    }
}
