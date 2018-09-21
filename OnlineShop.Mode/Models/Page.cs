using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Mode.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string MetaDescription { set; get; }

        [Required]
        public string MetaKeyword { set; get; }

        public bool? Status { set; get; }
    }
}