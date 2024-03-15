﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceWebSite.Domain.Enum;

namespace EcommerceWebSite.Domain.Models
{
    public class Order : BaseEntity
    {
        public decimal FinalPrice { get; set; }
        public DateTime Date { get; set; }
        public OrderState State { get; set; }
       // [ForeignKey("User")]
       //public int UserID { get; set; }
       // public User? User { get; set; }
        public List<OrderDetails>? OrderDetails { get; set; }
    }

}
