using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question: Find the greatest one amongst three numbers
namespace QandA
{
    class FindLargestNumBetweenThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if(a > c)
                {
                    Console.WriteLine("{0} is the greatest number.", a);
                }
                else
                {
                    Console.WriteLine("{0} is the greatest number.", c);
                }
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine("{0} is the greatest number.", b);
                }
                else
                {
                    Console.WriteLine("{0} is the greatest number.", c);
                }
            }
            Console.ReadLine();
        }
    }
}
