using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace excecise01.Models
{
    public class Order_product
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [MaxLength(10)]
        public int Qty { get; set; }

        [MaxLength(19)]
        public int PriceEach { get; set; }

        //Relations

        [MaxLength(10)]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [MaxLength(10)]
        public int ProductCode { get; set; }

        [ForeignKey("ProductCode")]
        public Order_product Product { get; set; }


    }
}