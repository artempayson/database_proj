using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    public class Cart
    {
        public int ID { get; set; }

        public List<CartItem> CartItems { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
