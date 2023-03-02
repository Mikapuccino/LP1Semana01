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
        }
    }
}