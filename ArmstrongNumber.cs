using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question: Check whether the number entered by the user is a Pallindrome number, iuse a do while loop to restart the process.
namespace QandA
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.Write("Enter a number here: ");
                int num = int.Parse(Console.ReadLine());
                int cube;
                int result = 0;
                int rem;
                int temp = num;
                while (num != 0)
                {
                    rem = num % 10;
                    cube = rem * rem * rem;
                    result = result + cube;
                    num = num / 10;
                }
                num = temp;
                if (num == result)
                {
                    Console.WriteLine("{0} is an Armstrong Number.", num);
                }
                else
                {
                    Console.WriteLine("{0} is not an Armstrong Number.", num);
                }
                Console.WriteLine("Press Y to continue or any other key to exit: ");
                value = Console.ReadLine();
            }
            while (value == "Y" || value == "y");

        }
    }
}
