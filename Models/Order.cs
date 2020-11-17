using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj.Models
{
    public class Order
    {
        public int id { get; set; }
        public int ordered_quantity { get; set; }
        public DateTime date_of_order { get; set; }
        public int supply_quantity { get; set; }//for admin
        public int remaining_quantity { get; set; }//for admin
        public DateTime date_of_supply { get; set; }//for admin

        public int hospitalId { get; set; }
        public Hospital Hospital { get; set; } 
    }
}
