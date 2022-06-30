using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question: Swap two numbers using formula
namespace QandA
{
    class SwapNumbersWithFormula
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("********Before Swapping********");
            Console.WriteLine("First Number: " + a);
            Console.WriteLine("Second Number: " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("********After Swapping********");
            Console.WriteLine("First Number: " + a);
            Console.WriteLine("Second Number: " + b);
            Console.ReadLine();
        }
    }
}
