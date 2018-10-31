using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Mabel Cao - 5202 Test 3
            //Question 1 - This program is a login system


            Console.WriteLine("Welcome to the program\nThis program is a login system");

            Console.WriteLine("Please enter in a username (must be at least 8 characters long)");
            string username = Console.ReadLine();
            
            

            Console.WriteLine("Please enter in a password (must be at least 8 characters long)");
            string password = Console.ReadLine();

            Console.WriteLine("Please re-enter in your password");
            string password2 = Console.ReadLine();

            Console.WriteLine("Username and Password have been accepted and set");





        }

        //Method for validating / checking if the username is at least 8 characters long
        public string ValidUsername(string username)
        {
           

            if (username.Length < 8)
            {
                Console.WriteLine("That username is not valid, please re-enter in a username");
                username = Console.ReadLine();
            }
           // else { Console.WriteLine("That username is valid"); }
                return "That username is valid";
            
        }

        public string ValidPassword(string password, string password2)
        {
            if (password2 == password)
            { }
            return "";
        }


    }
}
