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
            if (isUserSaved)
            {
                Console.WriteLine("Successfully Saved!!!.");
            }
        }
    }
}
