using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Web.Models
{
    public class ApplicationUserGroupViewModel
    {
        public string UserId { set; get; }

     
        public int GroupId { set; get; }

       
        public virtual ApplicationUserViewModel ApplicationUser { set; get; }

      
        public virtual ApplicationGroupViewModel ApplicationGroup { set; get; }
    }
}