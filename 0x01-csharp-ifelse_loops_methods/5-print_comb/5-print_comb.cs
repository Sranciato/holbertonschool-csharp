using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 100)
            {
                if (num < 99)
                {
                    Console.Write("{0:d2}, ", num);    
                }
                else
                {
                    break;
                }
                num++;
            }
            Console.WriteLine("{0:d2}", num);
        }
    }
}
