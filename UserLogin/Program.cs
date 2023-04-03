using System;
using System.Runtime.CompilerServices;

namespace UserLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.userName = "LinaT";
            user.password = "0000";
            user.facNumber = "121220100";
            user.role = 0;

            Console.WriteLine("Username: " + user.userName + " " + "Password: " + user.password + " " + "FacNumber: " + user.facNumber + " " + "Role: " + user.role);
           
        }
    }
}
