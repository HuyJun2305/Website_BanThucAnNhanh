using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Model
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; } // Navigation property
        public Guid FoodId { get; set; }
        public Food Food { get; set; } // Navigation property
        public int Quantity { get; set; }
    }
}
