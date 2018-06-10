using System;
using System.Linq;

namespace _05.GeneratingCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input = int.Parse(Console.ReadLine());

            var vector = new int[input];

            Generate(set ,vector ,0 ,-1);
        }

        static void Generate(int[] set, int[] vector, int index, int border)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ",vector));
            }
            else
            {
                for (int i = border + 1; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    Generate(set, vector,index + 1,i);
                }
            }
        }
    }
}
