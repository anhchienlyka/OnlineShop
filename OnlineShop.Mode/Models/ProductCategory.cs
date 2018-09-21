using OnlineShop.Mode.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Mode.Models
{ 
    [Table("ProductCategories")]
   public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]//thuoc tinh tu dong tang cho ID
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]

        public string Alias { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public int? PrentID { set; get; }
        public int? DisplayOrder { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }

    }
}
