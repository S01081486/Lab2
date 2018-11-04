using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; // declare first number to add
            int number2; // declare second number  to add
            int sum; // declare sum of number1 and number2

            Console.Write("Enter first integer: "); // prompt user
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: "); // prompt user
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 * number2; // multiply numbers

            Console.WriteLine("Sum is (0)", sum); // display sum

            Console.WriteLine("(O)\n(1)", "Hello World!", "From Zach");
        }
    }
}

// Our program executes at main //
// An example of a method is main method //
