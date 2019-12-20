using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
      
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>(100);
            for (int i = 1; i < collection.Capacity; i++)
            {
                collection.Add(i);
            }
            foreach (int x in collection)
            {
                if (x % 5 == 0 && x % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine("{0}", x);
                }
            }
            Console.ReadKey();
        }
    }
}
