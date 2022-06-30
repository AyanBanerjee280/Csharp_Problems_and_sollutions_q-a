using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_odd_or_even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it is Even or Odd: ");//getting user input
            int number = int.Parse(Console.ReadLine()); //DataType Conversion

            if (number % 2 == 0) //condition1
            {
                Console.WriteLine("This is an even number");
            }
            else //condition2
            {
                Console.WriteLine("This is an odd number");
            }
            Console.ReadLine();
        }
    }
}
