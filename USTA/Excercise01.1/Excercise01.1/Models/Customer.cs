using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace excecise01.Models
{
    public class Customer
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string FirstName {  get; set; }

        [MaxLength(255)]
        public string Phone {  get; set; }

        [MaxLength(255)]
        public string Address01 {  get; set; }

        [MaxLength(255)]
        public string Address02 { get; set; }

        [MaxLength(255)]
        public string City { get; set; }

        [MaxLength(255)]
        public string State { get; set; }

        [MaxLength(10)]
        public int PostalCode { get; set; }

        [MaxLength(255)]
        public string Country { get; set; }

        [MaxLength(19)]
        public int CreditLimit { get; set; }

        //Relations

        [MaxLength(10)]
        public int SalesRepEmployeeNum { get; set; }

        [ForeignKey("SalesRepEmployeeNum")]
        public Employee Employee { get; set; }

        public List<Order> Order { get; set; }

        public List<Payment> Payment { get; set; }


    }
}