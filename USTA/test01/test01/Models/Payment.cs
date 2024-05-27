using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test01.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Payment Date")]
        public string PaymentDay { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public string Amount { get; set; }
        
    }
}
