using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersApp.Models;

public class Employee 
{
    [Key]
    public int Id { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string Extension { get; set; }

    public string Email { get; set; }

    public string JobTitle { get; set; }


    // Relationships

    public int OfficeCode { get; set; }
    [ForeignKey("OfficeCode")]
    public Office Office { get; set;}

    public int ReportsTo { get; set; }
    public Employee Manager { get; set; }

    public List<Employee> Subordinates { get; set; }
}