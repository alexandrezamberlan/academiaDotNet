using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WinFormsAppSerializadorSOAP
{
    public class Arquivo
    {
        public static string lerArquivo(string dadosArquivo)
        {
            using (var leitor = new StreamReader(dadosArquivo))
            {
                return leitor.ReadToEnd();
            }   
        }
    }
}
