using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.UI
{
    class User
    {
        private bool SaveRegistration(string name, string username, string encryptedPassword)
        {
            // Save user info
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Username: {0}", username);
            Console.WriteLine("Password: {0}", encryptedPassword);
            return true;
        }

        private string EncryptPassword(string password)
        {
            // Do password encryption
            string encryptedPassword = "56857cfc709d3996f057252c16ec4656f5292802";
            return encryptedPassword;
        }

        public bool Register(string name, string username, string password)
        {
            string encryptedPassword = this.EncryptPassword(password);
            return this.SaveRegistration(name, username, encryptedPassword);
        }
    }
}
