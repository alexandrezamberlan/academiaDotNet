using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDasDisciplinas
{
    internal class Aluno
    {
        /// <summary>
        /// armazena a matricula de um aluno
        /// </summary>
        string matricula;

        /// <summary>
        /// armazena o nome completo de um aluno
        /// </summary>
        string nome;

        /// <summary>
        /// armazena o email da instituição do aluno
        /// </summary>
        string email;
        
        /// <summary>
        /// método construtor que instancia um objeto com todos os seus atributos
        /// </summary>
        /// <param name="matricula">recebe a matricula de um aluno</param>
        /// <param name="nome">recebe o nome completo de um aluno</param>
        /// <param name="email">recebe o email do aluno</param>
        public Aluno(string matricula, string nome, string email)
        {
            this.Matricula = matricula;
            this.Nome = nome;                       
            this.Email = email;
        }


        /// <summary>
        /// propriedade/atributo que acessa a variável matricula
        /// </summary>
        public string Matricula { get => matricula; set => matricula = value; }

        /// <summary>
        /// propriedade/atributo que acessa a variável nome
        /// </summary>
        public string Nome { get => nome; set => nome = value; }

        /// <summary>
        /// propriedade que acessa a variável email
        /// </summary>
        public string Email { get => email; set => email = value; }

        /// <summary>
        /// metodo que retorna o primeiro nome e o ultimo sobrenome
        /// </summary>
        /// <returns></returns>
        public string pegaNomeSobrenome()
        {
            string[] vetorNomes = this.Nome.Split(' ');
            if (vetorNomes.Length == 1)
            {
                return vetorNomes[0];
            }
            return vetorNomes[0] + " " + vetorNomes[ vetorNomes.Length - 1 ];
        }


    }
}
