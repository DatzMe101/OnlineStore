using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.UI
{
    class Seller: User
    {
        public void SellProduct()
        {
            Console.WriteLine("Sell Product");
        }
        
        public void AddProduct()
        {
            Console.WriteLine("Add Product");
        }
    }
}
