using Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new Context())
            {
                var goods = c.Goods.ToList();
            }
        }
    }
}
