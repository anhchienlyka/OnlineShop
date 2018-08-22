using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Mode.Models
{
    [Table("SupportOnline")]
    public  class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]//thuoc tinh tu dong tang cho ID
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Department { set; get; }
        [Required]
        public string Skype { set; get; }
        [Required]
        public string Mobile { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Yahoo { set; get; }
        [Required]
        public string Facebook { set; get; }
        public bool? Status { set; get; }
    }
}
