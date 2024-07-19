using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebData.Model
{
    public class Food
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string QrCode { get; set; }
        public string Image { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
