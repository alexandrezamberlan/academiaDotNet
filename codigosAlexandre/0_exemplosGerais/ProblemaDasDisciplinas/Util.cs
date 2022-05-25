using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDasDisciplinas
{
    class Util
    {
        /// <summary>
        /// método de classe que recebe uma lista de alunos e a exibe no console/terminal
        /// </summary>
        /// <param name="frase">texto para exibir no terminal</param>
        /// <param name="lista">lista de alunos matriculados</param>
        public static void exibirLista(string frase, List<Aluno> lista)
        {
            Console.WriteLine(frase);
            foreach (Aluno i in lista)
            {
                Console.WriteLine(i.Matricula + " - " + i.pegaNomeSobrenome() + " - " + i.Email);
            }
        }


        /// <summary>
        /// método de classe que abre dois arquivos texto com nomes de alunos em disciplinas e popula nas listas
        /// </summary>
        /// <param name="lista1">contém todos os alunos da disciplina 1</param>
        /// <param name="lista2">contém todos os alunos da disciplina 2</param>
        public static void carregarListas(List<Aluno> lista1, List<Aluno> lista2)
        {
            Console.WriteLine("Trabalhando com listas e arquivos ....");
            StreamReader leitor;

            string nomeArquivo1 = "";
            string nomeArquivo2 = "";
            string[] vetorDados;

            try
            {
                Console.Write("Digite nome do arquivo com nomes de alunos da disciplina 1: ");
                nomeArquivo1 = Console.ReadLine();

                leitor = new StreamReader(nomeArquivo1);

                do
                {
                    vetorDados = leitor.ReadLine().Split(";"); //matricula;nome;email
                    lista1.Add(new Aluno(vetorDados[0], vetorDados[1], vetorDados[2]));

                } while (!leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo1 com problemas ou inexistente");
            }

            try
            {
                Console.Write("Digite nome do arquivo com nomes de alunos da disciplina 2: ");
                nomeArquivo2 = Console.ReadLine();

                leitor = new StreamReader(nomeArquivo2);

                do
                {
                    vetorDados = leitor.ReadLine().Split(";"); //matricula;nome;email
                    lista2.Add(new Aluno(vetorDados[0], vetorDados[1], vetorDados[2]));

                } while (!leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo2 com problemas ou inexistente");
            }
        }
    }
}
