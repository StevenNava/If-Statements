using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // If statement practice
            Console.WriteLine("This program adds together two numbers greater than 10. It will only take in numbers greater than 10. Any others will be rejected.");
            Console.WriteLine("What is your first number?");
            int FirstInput = -1;
            if(!(Int32.TryParse(Console.ReadLine(), out FirstInput))) 
            {
                FirstInput = -1;
            }
            while(FirstInput <= 10)
            {
                // If statement 1
                if(FirstInput == -1)
                {
                    Console.WriteLine("Your entry for the first input is not a number. Please enter a valid number greater than 10.");
                } else
                {
                    Console.WriteLine("Input 1 is not greater than 10. Please input a number greater than 10.");
                }
                if (!(Int32.TryParse(Console.ReadLine(), out FirstInput)))
                {
                    FirstInput = -1;
                }
            }

            Console.WriteLine("What is your second number?");
            int SecondInput = -1;
            if (!(Int32.TryParse(Console.ReadLine(), out SecondInput)))
            {
                SecondInput = -1;
            }
            while (SecondInput <= 10)
            {
                // If statement 1
                if (SecondInput == -1)
                {
                    Console.WriteLine("Your entry for the second input is not a number. Please enter a valid number greater than 10.");
                }
                else
                {
                    Console.WriteLine("Input 2 is not greater than 10. Please input a number greater than 10.");
                }
                if (!(Int32.TryParse(Console.ReadLine(), out SecondInput)))
                {
                    SecondInput = -1;
                }
            }

            Console.WriteLine(FirstInput + " plus " + SecondInput + " equals " + (FirstInput + SecondInput).ToString());
            // Readline stops the program from exiting until a key/enter are pressed.
            Console.WriteLine("Press enter to exit the program.");
            Console.ReadLine();
        }
    }
}
