using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaEmail
{
    class Usuario {
        string nomeCompleto;
        string email;

        private void gerarEmail() {
            string[] vetorDados = this.nomeCompleto.Split(' ');
            this.email = vetorDados[ vetorDados.Length - 1 ] + "." + vetorDados[0] + "@ufn.edu.br";
            this.email = this.email.ToLower();
        }

        public Usuario(string nome) {
            this.nomeCompleto = nome;
            this.gerarEmail();
        }

        public string Nome { get => nomeCompleto; set => nomeCompleto = value; }

        public string Email { get => email; }
    }
}