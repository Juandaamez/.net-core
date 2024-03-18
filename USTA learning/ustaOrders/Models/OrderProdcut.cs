using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersApp.Models;

public class OrderProduct 
{
    [Key]
    public int Id { get; set; }

    public int Qty { get; set; }

    public int PriceEach { get; set; }

    // Relationships

    public int OrderId { get; set; }
    [ForeignKey("OrderId")]
    public Order Order { get; set; }

    public int ProductCode { get; set; }
    [ForeignKey("ProductCode")]
    public Product Product { get; set; }
}