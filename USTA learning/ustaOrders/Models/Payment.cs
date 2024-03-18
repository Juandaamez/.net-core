using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersApp.Models;

public class Payment 
{
    [Key]
    public int Id { get; set; }

    public string CheckNum { get; set; }

    public DateTime PaymentDate { get; set; }

    public string Amount { get; set; }

    // Relationships

    public int CustomerID { get; set; }
    [ForeignKey("CustomerID")]
    public Customer Customer { get; set; }

}