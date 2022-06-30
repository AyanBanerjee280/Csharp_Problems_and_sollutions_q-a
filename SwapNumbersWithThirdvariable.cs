using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question: Swap two numbers using third variable
namespace QandA
{
    class SwapNumbersWithThirdvariable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            int temp;
            Console.WriteLine("First Number = " + firstNum);
            Console.WriteLine("Second Number = " + secondNum);
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("First Number = " + firstNum);
            Console.WriteLine("Second Number = " + secondNum);
            Console.ReadLine();
        }
    }
}
