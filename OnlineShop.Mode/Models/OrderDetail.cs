using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Mode.Models
{
    [Table("OrderDetails")]
  public  class OrderDetail
    {
        [Key]       
        public int OrderID { get; set; }
        [Key]
        public int ProdcutID { get; set; }

        public int Quantity { set; get; }
        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }
        [ForeignKey("ProdcutID")]
        public virtual Product Product { get; set; }


    }
}
