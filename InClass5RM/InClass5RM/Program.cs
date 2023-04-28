
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass5RM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            string passWord = "";
            bool repeat = false;
            int randomValue = 0;

            //1. Ask the user to enter user name:

            do
            {
                Console.WriteLine("Please enter a username (at lest 8 Characters long): ");
                userName = Console.ReadLine();

                if (userName.Length <= 8)
                {
                    Console.WriteLine("username must be at least 8 characters long\n");
                }

            } while (userName.Length <= 8);

            //2. Ask user to enter password:

            while (!repeat)
            {
                Console.WriteLine("\nPlease enter a password includes a special character (8 characters long): ");
                passWord = Console.ReadLine();
                if (passWord.Length >= 8 && passWord.Any(char.IsPunctuation))
                {
                    repeat = true;
                }
                else
                {
                    Console.WriteLine("Invalid password. Password must be 8 characters long and include a special character.");
                }
            }        

            //3. Convert username and password to lowercase:

            userName = userName.ToLower();

            passWord= passWord.ToLower();

            //4. Alter the username:

            userName = userName.Insert(4, "@");

            //5. Add random value to password:

             Random randGen = new Random();
            randomValue = randGen.Next(1, 100);

            passWord = passWord + randomValue;

            //6. Show username and password:

            Console.WriteLine($"\nUsername: {userName}");
            Console.WriteLine($"Password: {passWord}");

            Console.ReadKey();
        }
    }
}
