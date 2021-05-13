using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Java_String_Tokens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una cadena");
            String cadena = Console.ReadLine();
            String[] cadenas = Regex.Split(cadena,"/t");

            Console.WriteLine(cadenas.Length);
            foreach (string cad in cadenas)
            {
                Console.WriteLine(cad);
            }
        }
    }
}
