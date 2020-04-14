using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0, second = 0;
            while (first < 10)
            {
                second = first + 1;
                while (second < 10)
                {
                    Console.Write(first + "" + second);
                    if (!(first == 8 && second == 9))
                        Console.Write(", ");
                    second++;
                }
                first++;
            }
            Console.WriteLine("");
        }
    }
}
