using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;
            double answer = 0;
            Console.WriteLine("What is n1: ");
            n1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("What is n2: ");
            n2 = Double.Parse(Console.ReadLine());

            answer = n1 / n2;
            Console.WriteLine("The answer is {0:0.000000}",answer);

            string message = "School of Computer Science";
            string str1 = " ";
            string str2 = " ";
            string trimmedMessage = message.Replace(str1, str2);
            Console.WriteLine(message);
            Console.WriteLine(trimmedMessage);

            int result = FindSumVariables();
            Console.WriteLine(result);

            Console.WriteLine($"The amount of letters in{trimmedMessage} is {trimmedMessage.Length}");
            Console.ReadKey();
        }
        static int FindSumVariables()
        {
            int limit = 1000;
            int sum = 0;
            for (int i = 1; i < limit; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }
            return (sum);

        }

        static int EvenTermsFibonacci()
        {
            int limit = 4000000;
            int sum = 0;

            int fib1 = 0;
        }
    }
}
