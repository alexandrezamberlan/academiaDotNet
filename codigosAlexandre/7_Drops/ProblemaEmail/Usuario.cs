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

        //construtor usado no cadastro de um usuario
        public Usuario(string nome) {
            this.nomeCompleto = nome;
            this.gerarEmail();
        }

        //construtor usado para popular a lista a partir do arquivo (banco)
        public Usuario(string nome, string email) {
            this.nomeCompleto = nome;
            this.email = email;
        }

        public string Nome { get => nomeCompleto; set => nomeCompleto = value; }

        public string Email { get => email; }
    }
}