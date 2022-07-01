using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question: Check whether the number entered by the user is a Composite Number or a Prime number.
namespace QandA
{
    class CheckCompositeOrPrime
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.Write("Enter a number here: ");
                int num = int.Parse(Console.ReadLine());
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("{0} is a Prime Number.", num);
                }
                else
                {
                    Console.WriteLine("{0} is a Composite Number.", num);
                }
                Console.WriteLine("Press y to continue or any other key to exit ");
                value = Console.ReadLine();
            }
            while (value == "Y" || value == "y");

        }
    }
}

