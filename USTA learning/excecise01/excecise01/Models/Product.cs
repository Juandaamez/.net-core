using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace excecise01.Models
{
    public class Product
    {
        [Key]
        [MaxLength(10)]
        public int Code { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(10)]
        public int Scale { get; set; }

        [MaxLength(255)]
        public string Vendor {  get; set; }

        [MaxLength(255)]
        public string PdtDescription {  get; set; }

        [MaxLength(10)]
        public int QtylnStock {  get; set; }

        [MaxLength(19)]
        public int BuyPrice { get; set; }

        [MaxLength(255)]
        public string MSRP { get; set; }

        //Relations

        [MaxLength(10)]
        public int ProdcutLineId { get; set; }

        [ForeignKey("ProdcutLineId")]
        public ProductLine ProductLine { get; set; }


    }
}