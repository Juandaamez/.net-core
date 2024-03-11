using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace excecise01.Models
{
    public class Order
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate {  get; set; }

        [MaxLength(10)]
        public int Status {  get; set; }

        [MaxLength(255)]
        public string Comments {  get; set; }


        //Relations

        [MaxLength(10)]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }


    }
}