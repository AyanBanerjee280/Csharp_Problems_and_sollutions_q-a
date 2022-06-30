using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question: Find the greater one between two numbers
namespace odd_even_num
{
    class FindLargerNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is the greater number.", a);
            }
            else
            {
                Console.WriteLine("{0} is the greater number.", b);
            }
            Console.ReadLine();
        }
    }
}
