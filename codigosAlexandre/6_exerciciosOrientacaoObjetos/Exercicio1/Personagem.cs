using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Personagem
    {
        /// <summary>
        /// variavel que armazena o nome de um personagem
        /// </summary>
        string nome;

        /// <summary>
        /// variável que armazena o poder de um personagem entre 0 e 1000
        /// </summary>
        int poder;


        /// <summary>
        /// construtor vazio
        /// </summary>
        public Personagem()
        {
        }

        /// <summary>
        /// construtor para um personagem com todos os atributos/variáveis
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="poder"></param>
        public Personagem(string nome, int poder)
        {
            this.Nome = nome;
            this.Poder = poder;
        }


        /// <summary>
        /// propriedade de acesso ao nome
        /// </summary>
        public string Nome { get => nome; set => nome = value; }

        /// <summary>
        /// propriedade de acesso do poder
        /// </summary>
        public int Poder { get => poder; set => poder = value; }


        /// <summary>
        /// método de instancia/objeto para exibir dados completos de um personagem
        /// </summary>
        public void exibirDados()
        {
            Console.Write("Nome do personagem: " + Nome + ". Poder: " + Poder);
        }


        public static void mostrarMaisPoderoso(List<Personagem> lista)
        {
            Personagem maisPoderoso = lista[0];
            foreach (Personagem i in lista)
            {
                if (i.Poder > maisPoderoso.Poder)
                {
                    maisPoderoso = i;
                }
            }

            Console.WriteLine("O mais poderoso é: ");
            maisPoderoso.exibirDados();
        }

        public static string pegarMaisPoderoso(List<Personagem> lista)
        {
            Personagem maisPoderoso = lista[0];
            foreach (Personagem i in lista)
            {
                if (i.Poder > maisPoderoso.Poder)
                {
                    maisPoderoso = i;
                }
            }

            return maisPoderoso.Nome + " - " + maisPoderoso.Poder;
        }
    }
}
