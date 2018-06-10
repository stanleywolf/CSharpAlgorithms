using System;

namespace _03.RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Print(input);
        }

        static void Print(int index)
        {
            if (index == 0)
            {
                return;
            }
            Console.WriteLine(new string('*',index));

            Print(index - 1);

            Console.WriteLine(new string('#',index));
        }
    }
}
