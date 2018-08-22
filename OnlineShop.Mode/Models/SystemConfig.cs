using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Mode.Models
{  [Table("SystemConfigs")]
 public   class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Code { set; get; }
        [Required]
        public string ValueString { set; get; }
        public int? ValueInt { set; get; }
    }
}
