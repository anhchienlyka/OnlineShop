using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Web.Models
{
    public class OrderViewModel
    {
        public int ID { get; set; }

       
        public string CustomerName { set; get; }

        
        public string CustomerAddress { set; get; }
       
        public string CustomerEmail { set; get; }
        
        public string CustomerMobile { set; get; }

        
        public string CustomerMessage { set; get; }
      
        public string PaymentMethod { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }
        [MaxLength(128)]
        public string CustomerId { set; get; }

        public string BankCode { set; get; }
        public virtual IEnumerable<OrderDetailViewModel> OrderDetails { set; get; }
    }
}