using System.ComponentModel.DataAnnotations;

namespace OrdersApp.Models;

public class Office 
{
    [Key]
    public int Id { get; set; }

    public string City { get; set; }

    public string Phone { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string State { get; set; }

    public string Country { get; set; }

    public string PostalCode { get; set; }

    public string Territory { get; set; }

    // Relationships

    public List<Employee> Employees { get; set; }
}