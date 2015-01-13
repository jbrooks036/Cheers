using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");

            // Step 1:  Getting user's name and print it.
            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            string capName = name.ToUpper();
            System.Console.WriteLine("Welcome, " + name);
            
            // Step 2:  Cheer the user on.
            // break up user name into individual characters
            char[] nameLtrs = name.ToCharArray();
            
            // get lower case version of each character & print it out
            foreach (char ltr in name.ToLower())
            {
                string article;
                if ("halfnorsemix".IndexOf(ltr) >= 0)
                {
                    article = "a ";
                } else {
                    article = "an ";
                }
                System.Console.WriteLine("Give me " + article + ltr + " !");
                // nameLtrs[ltr] = System.Char.ToUpper(nameLtrs[ltr]);
            }
           
            // final line should have name in all caps
            System.Console.WriteLine(capName + " is FANTASTIC!");

            // get user's birthday
            System.Console.WriteLine("When is your birthday?");
            date bDayStr = System.Console.ReadLine();

            // adding another line for github update

            // finish off the console window
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
