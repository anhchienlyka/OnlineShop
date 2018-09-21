using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Mode.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]//thuoc tinh tu dong tang cho ID
        public int ID { set; get; }


        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        public virtual IEnumerable<Menu> Menus { set; get; }
            
           
    }
}