using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question: Reverse a number which is entered by the user
namespace QandA
{
    class ReversingANumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to reverse it: ");
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            int rem;
            while(num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reversed number is: " + result);
            Console.ReadLine();
        }
    }
}
