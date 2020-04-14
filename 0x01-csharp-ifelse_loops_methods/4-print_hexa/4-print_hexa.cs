using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 99)
            {
                Console.WriteLine("{0} = 0x{0:X}", num);
                num++;
            }
        }
    }
}
