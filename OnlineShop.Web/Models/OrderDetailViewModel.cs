using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Web.Models
{
    public class OrderDetailViewModel
    {
        public int OrderID { get; set; }
     
        public int ProdcutID { get; set; }

        public int Quantity { set; get; }
      
        public virtual OrderViewModel Order { set; get; }
        
        public virtual ProductViewModel Product { get; set; }
    }
}