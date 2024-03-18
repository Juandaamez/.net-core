using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace excecise01.Models
{
    public class Employee
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string Extension {  get; set; }

        [MaxLength(255)]
        public string Email {  get; set; }

        [MaxLength(100)]
        public string JobTitle {  get; set; }

        //Relations

        [MaxLength(10)]
        public int OfficeId { get; set; }

        [ForeignKey("OfficeId")]
        public Office Office { get; set; }


        public int ReportsTo { get; set; }

        [ForeignKey("ReportsTo")]
        [InverseProperty("Employee")]
        public Employee Boss { get; set; }


    }
}