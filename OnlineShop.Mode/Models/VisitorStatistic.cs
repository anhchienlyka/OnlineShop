﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Mode.Models
{
    [Table("VisitorStatistics")]
   public class VisitorStatistic
    {
        [Key]      
        public Guid ID { set; get; }
        public DateTime VisitorDate { set; get; }
       [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}
