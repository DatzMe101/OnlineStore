using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            string name = "Elmer";
            string username = "datzme101";
            string password = "TempPassword";
            bool isUserSaved = user.Register(name, username, password);
            string firstName = user.GetFirstName();
            if (isUserSaved)
            {
                Console.WriteLine("First Name: {0}", firstName);
                Console.WriteLine("Successfully Saved!!!.");
            }

            Customer customer = new Customer();
            customer.BuyProduct();
            customer.Register("Customer 1", "customer-1", "TempPassword");

            Seller seller = new Seller();
            seller.AddProduct();
            seller.SellProduct();
            seller.Register("Seller 1", "seller-1", "TempPassword");
        }
    }
}
