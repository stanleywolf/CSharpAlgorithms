using System;
using System.Dynamic;

namespace _04.Generate01Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var arr = new int[input];

            Generate(0,arr);
        }

        static void Generate(int index, int[] arr)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join("",arr));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    arr[index] = i;
                    Generate(index + 1,arr);
                }
            }
        }
    }
}
