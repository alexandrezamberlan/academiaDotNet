using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoJogadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //trazer os dados do arquivo para a lista, toda a vez que o programa é executado
            StreamReader leitor = new StreamReader("jogadores.dat");
            String linha;
            String[] vetorDados;
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");
                listaJogadores.Add( new Jogador(vetorDados[0], vetorDados[1]) );

                //popular o textBox da lista de jogadores
                textBox_listaJogadores.AppendText(vetorDados[0] + " - " + vetorDados[1] + Environment.NewLine);
            } while (!leitor.EndOfStream);

            leitor.Close();

            
            
        }

        private void button_gravar_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (textBox_nomeJogador.Text.Equals(""))
            {
                MessageBox.Show("É preciso digitar um nome completo!", "Alerta");
                return;
            }
            
            //transformar o nome para maiusculo
            textBox_nomeJogador.Text = textBox_nomeJogador.Text.ToUpper();

            String email;

            //gravar numa lista desde que não esteja na lista
            if (Jogador.jaCadastrado(textBox_nomeJogador.Text, listaJogadores))
            {
                MessageBox.Show("Jogador já cadastrado!", "Alerta");
            } else
            {
                //vetorNomes[alexandre][de][oliveira][zamberlan][   <- "alexandre de oliveira zamberlan"

                String[] vetorNomes = textBox_nomeJogador.Text.ToLower().Split(" ");
                
                if (vetorNomes.Length > 1)
                {
                    //zamberlan.alexandre@ufn.edu.br
                    email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br";
                } else
                {
                    email = vetorNomes[0] + "@ufn.edu.br";
                }

                listaJogadores.Add( new Jogador(textBox_nomeJogador.Text, email) );
                textBox_listaJogadores.AppendText(textBox_nomeJogador.Text + " - " + email + Environment.NewLine);

                
                //gravar no arquivo
                StreamWriter escritor = new StreamWriter("jogadores.dat", true); //se o arquivo já existe, apenas adiciona novo jogador no final do arquivo
                escritor.WriteLine(textBox_nomeJogador.Text + ";" + email);
                escritor.Close();
            }
            textBox_nomeJogador.Text = "";

            
        }

        private void button_limpar_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_nomeJogador.Text = "";
            textBox_listaJogadores.Text = "";
            listaJogadores.Clear();
        }

        List<Jogador> listaJogadores = new List<Jogador>();
    }
}
