using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace excecise01.Models
{
    public class ProductLine
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [MaxLength(255)]
        public string DesclnText { get; set; }

        [MaxLength(255)]
        public string DesclnHTLM { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }

        public List<Product> Product { get; set; }

    }
}