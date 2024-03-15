using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebSite.Domain.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        //Relation
        [ForeignKey("Cart")]
        public int CartID { get; set; }
        public Cart? Cart { get; set; }

        public List<Order>? Orders { get; set; }
    }
}
