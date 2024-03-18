using System.ComponentModel.DataAnnotations;

namespace excecise01.Models
{
    public class Office
    {
        [Key]
        [MaxLength(10)]
        public int Code { get; set; }

        [MaxLength(255)]
        public string City { get; set; }

        [MaxLength(255)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string Address01 {  get; set; }

        [MaxLength(255)]
        public string Address02 {  get; set; }

        [MaxLength(255)]
        public string State {  get; set; }

        [MaxLength(255)]
        public string Country {  get; set; }

        [MaxLength(10)]
        public int PostalCode {  get; set; }

        [MaxLength(200)]
        public string Territory {  get; set; }

    }
}