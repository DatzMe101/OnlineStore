using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Encryptions;


namespace OnlineStore.UI
{
    class User : Profile
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
            Authentication auth = new Authentication();
            return auth.EncryptPassword(password);
        }

        public bool Register(string name, string username, string password)
        {
            string encryptedPassword = this.EncryptPassword(password);
            return this.SaveRegistration(name, username, encryptedPassword);
        }
    }
}
