using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test01.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        public string OrderDate { get; set; }

        [Required]
        [Display(Name = "Required Date")]
        public string RequiredDate { get; set; }

        [Required]
        [Display(Name = "Shipped Date")]
        public string ShippedDate { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Comments")]
        public string Comments { get; set; }

    }
}
