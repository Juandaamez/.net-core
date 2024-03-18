using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersApp.Models;

public class Customer 
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string LastName { get; set; }

    public string Phone { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string PostalCode { get; set; }
    public string Country { get; set; }
    public int CreditLimit { get; set; }

    // Relationships

    public int SalesRepEmployeeNum { get; set; }
    [ForeignKey("SalesRepEmployeeNum")]
    public Employee Employee { get; set; }

    public List<Payment> Payment { get; set; }

    public List<Order> Orders { get; set; }
}