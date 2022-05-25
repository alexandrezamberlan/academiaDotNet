using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drop6_listaArquivoEscrita
{
    internal class Pessoa
    {        
        public string nome;
        public string email; //atributo será usado com identificador

        //método construtor
        public Pessoa(string n, string e)
        {
            nome = n;
            email = e;
        }
    }
}
