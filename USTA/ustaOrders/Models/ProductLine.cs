using System.ComponentModel.DataAnnotations;

namespace OrdersApp.Models;

public class ProductLine 
{
    [Key]
    public int Id { get; set; }

    public string DescLnText { get; set; }

    public string DescLnHTML { get; set; }

    public string Image { get; set; }

    // Relationships

    public List<Product> Products { get; set; }
}