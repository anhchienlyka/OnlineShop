using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Web.Models
{
    public class PageViewModel
    {
        public int ID { set; get; }

       
        public string Name { set; get; }

        
        public string MetaDescription { set; get; }

      
        public string MetaKeyword { set; get; }

        public bool? Status { set; get; }
    }
}