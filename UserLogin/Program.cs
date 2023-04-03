using System;
using System.Runtime.CompilerServices;

namespace UserLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.userName = "Li";
            user.password = "0000";
            user.facNumber = "121220100";
            user.role = 0;

            LoginValidation login = new LoginValidation();
            login.ValidateUserInput(user.userName, user.password);

            //Console.WriteLine("Username: " + user.userName + " " + "Password: " + user.password + " " + "FacNumber: " + user.facNumber + " " + "Role: " + user.role);
           
        }
    }
}
