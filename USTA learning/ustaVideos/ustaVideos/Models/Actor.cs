using System.ComponentModel.DataAnnotations;

namespace ustaVideos.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Full name lenght must be between 3 and 40", MinimumLength = 3)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Biography")]
        public string Bio {  get; set; }
    }
}