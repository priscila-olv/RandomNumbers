using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random NumRand = new Random();

            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(NumRand.Next(100));
            }

            Console.WriteLine("Lista de números randômicos: ");
            Console.WriteLine();
            foreach (int number in numbers)
            {
                Console.WriteLine(number.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Menor número: " + numbers.Min());
            Console.WriteLine("Maior número: " + numbers.Max());
        }
    }
}
