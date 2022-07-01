using System; //Only this is in use
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question: Print all Composite numbers up to 100
namespace QandA
{
    class CompositeUpToHundred
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++)
            {
                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(number);
                }

            }
            Console.ReadLine();
        }
            
        
    }
}

