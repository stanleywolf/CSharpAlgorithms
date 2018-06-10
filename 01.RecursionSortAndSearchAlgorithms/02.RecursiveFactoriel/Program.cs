using System;

namespace _02.RecursiveFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            long sum = Factoriel(input);
            Console.WriteLine(sum);
        }

        static long Factoriel(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factoriel(num - 1);
        }
    }
}
