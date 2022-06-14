using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DuvidasAndre
{
    internal class Util
    {
        public static string parOuImpar(int numero)
        {
            if (numero % 2 == 0) return "PAR";
            else return "IMPAR";

        }

        public static string primo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i != 0) return "NÃO É PRIMO";
            }
            return "É PRIMO";
        }

        public static void mostrarTodosAntes(int numero)
        {
            for (int i = 0; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
