using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, s1; string s;
            Console.WriteLine("Введите целое число(N>0) N=");
            s = Console.ReadLine();
            N = Convert.ToInt32(s);
            Console.WriteLine("Квадраты чисел от 1 до N:");
            s1 = 0;
            for (int i = 1; i <= (2 * N - 1); i = i + 2)
            {
                s1 += i;
                Console.Write("{0},", s1);
            }
            Console.ReadKey();
        }
    }
}
