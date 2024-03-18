using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersApp.Models;

public class Product 
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public int Scale { get; set; }

    public string Vendor { get; set; }

    public string PdtDescription { get; set; }

    public int QtyLnStock { get; set; }

    public int BuyPrice { get; set; }

    public string MSRP { get; set; }

    // Relationships

    public int ProductLineId { get; set; }
    [ForeignKey("ProductLineId")]
    public ProductLine ProductLine { get; set; }

    public List<OrderProduct> OrderProducts { get; set;}
}