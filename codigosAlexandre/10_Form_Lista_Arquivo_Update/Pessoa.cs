using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Form_Lista_Arquivo_Update
{
    internal class Pessoa
    {
        string nomeCompleto;
        string email;

        public Pessoa(string nomeCompleto, string email)
        {
            this.NomeCompleto = nomeCompleto;
            this.Email = email;
        }

        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Email { get => email; set => email = value; }

        public static bool jaCadastrado(string nome, List<Pessoa> lista)
        {
            foreach (Pessoa i in lista)
            {
                if (i.NomeCompleto.Equals(nome))
                {
                    return true;
                }
            }
            return false;
        }

        public static int localiza(string nome, List<Pessoa> lista)
        {
            
            foreach (Pessoa i in lista)
            {
                if (i.NomeCompleto.Equals(nome))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27;
        }
    }
}
