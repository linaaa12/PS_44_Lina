using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class LoginValidation
    {
        public bool ValidateUserInput(string username, string password)
        {
            if (username.Length > 4 && password.Length < 6)
            {
                Console.WriteLine("UserName: {0}, Password: {1}", username, password);
                return true;
            }
            else
                Console.WriteLine("Incorrect input!");
                return false;
           
        }
    }
}
