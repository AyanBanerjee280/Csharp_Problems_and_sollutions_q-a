using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question: Find factorial
namespace QandA
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number here: ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 0; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial is " + fact + ".");
            Console.ReadLine();
        }
    }
}
