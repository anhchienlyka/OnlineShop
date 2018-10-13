using OnlineShop.Mode.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Mode.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }

    }
}