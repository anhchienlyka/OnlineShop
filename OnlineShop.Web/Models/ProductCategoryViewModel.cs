﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { set; get; }
      
        public string Name { set; get; }
        

        public string Alias { set; get; }
      
        public string Description { set; get; }
        public int? PrentID { set; get; }
        public int? DisplayOrder { set; get; }
       
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<ProductViewModel> Products { set; get; }
    }
}