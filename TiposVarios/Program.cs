using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            uint b = 2U;
            long c = 0x03L;
            ulong d = 0b100UL;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            char e = '\u0045';
            char f = '\u0066';
            char g = '\u011D';
            char h = '\u0126';
            Console.WriteLine("e = " + e);
            Console.WriteLine("f = " + f);
            Console.WriteLine("g = " + g);
            Console.WriteLine("h = " + h);

            double i = 10.45;
            float j = 3.1415f;
            decimal k = 42.69m;
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);
            Console.WriteLine("k = " + k);

            bool l = true;
            bool m = 10 < 1;
            Console.WriteLine("l = " + l);
            Console.WriteLine("m = " + m);
        }
    }
}
