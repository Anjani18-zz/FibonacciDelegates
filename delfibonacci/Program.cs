using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delfibonacci
{
    public delegate int fibonaccidelegate(int number);

    class Program
    {

        static void Main(string[] args)
        {
            fibonaccidelegate Del = new fibonaccidelegate(Fibonacci);
            int number;
            Console.WriteLine("Give the length of the sequence");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(" " + Del(i));
                Console.WriteLine("\t " + (i * 100) / (number) + "%\n");
            }
            Console.ReadKey();
        }
        public static int Fibonacci(int number)
        {
            if (number == 0 || number == 1)
                return number;
            else
                return (Fibonacci(number - 1) + Fibonacci(number - 2));
        }


    }

}

     
