using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test01.Models
{
    public class ProductLine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Desc In Text")]
        public string DescInText { get; set; }

        [Required]
        [Display(Name = "Desc In HTML")]
        public string DescInHtml { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }
        
    }
}
