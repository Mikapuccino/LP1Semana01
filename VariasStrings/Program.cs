using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Aqui tem um tab\t e isto deve ser um b grande\u0042";
            string s2 = "Agora uma linha\n e outro caracter \u0065";
            string s3 = @"Isto é literalmente escrito \t \u0042";
            string s4 = @"E \u0042isto também \n;;;";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            int x = 1;
            int y = 2;

            string s5 = "s" + 5 + " é uma string";
            string s6 = "s6 " + "mais uma variável " + x;
            string s7 = $"{x} mais {y} é igual a {x + y}";
            string s8 = $@"Isto é uma string verbatim {x + y}";
            string s9 = String.Format("Arg {0} e {1}", x, y);
            
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(s8);
            Console.WriteLine(s9);
            Console.WriteLine(@"Verbatim a seguir o exemplo x = {0}", x);
        }
    }
}