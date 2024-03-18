using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace excecise01.Models
{
    public class Payment
    {
        [Key]
        [MaxLength(255)]
        public string PaymentDay { get; set; }

        public DateTime LastName { get; set; }

        [MaxLength(19)]
        public int Amount { get; set; }


        //Relations

        [MaxLength(10)]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }


    }
}