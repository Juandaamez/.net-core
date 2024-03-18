using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersApp.Models;

public class Order 
{
    [Key]
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime RequiredDate { get; set; }

    public DateTime ShippedDate { get; set; }

    public int CustomerID { get; set; }

    public string Comments { get; set; }

    // Relationships

    public int CustomerId { get; set; }
    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }

    public List<OrderProduct> OrderProducts { get; set; }
}