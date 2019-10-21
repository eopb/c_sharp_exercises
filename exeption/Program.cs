using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routine_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Hold user input
                int input = 0;
                //Display options
                //Get user input 
                do
                {
                    Console.WriteLine("Please enter your option: ");
                    Console.WriteLine("1. Mathermatics fun");
                    Console.WriteLine("2. String fun");
                    Console.WriteLine("3. Exception fun");
                    Console.WriteLine("4. Exit");
                    try { input = Int32.Parse(Console.ReadLine()); }
                    catch { Console.WriteLine("Unable to parse input. Please try again."); continue; }
                } while (input < 1 || input > 4);

                if (input == 1) MathFunc();

                if (input == 2) StringFunc();

                if (input == 3) ExceptionFunc();

                if (input == 4)
                {
                    Console.WriteLine("You want to exit....bye for now");
                    break;
                }
            }
        }
        static public int MathFunc()
        {
            Console.WriteLine("Welcome to 1. Mathermatics fun");
            return 5;
        }
        static public string StringFunc()
        {
            Console.WriteLine("Welcome to 2. String fun");
            return "String";

        }
        static public void ExceptionFunc() { Console.WriteLine("Welcome to 3. Exception fun"); }
    }
}





