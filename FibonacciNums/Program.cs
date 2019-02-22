using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNums
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите индекс(начинается с нуля) числа из последовательности Фибоначчи");
            int index=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число {FibonacciNums(index)} является {index}-ым в последовательности Фибоначчи");
            Console.ReadLine();
        }
        public static int FibonacciNums(int index)
        {
            List<int> fibonacciNumbers = new List<int> { 1, 1 };
            if (index == 0 || index == 1)
                return 1;
            while (index != 1)
            {
                var previous1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous1 + previous2);
                index--;
            }
            return fibonacciNumbers.Last();
        }
    }
}
