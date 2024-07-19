using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Model
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderTime { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } 
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
