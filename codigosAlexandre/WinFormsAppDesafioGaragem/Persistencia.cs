using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDesafioGaragem
{
    internal class Persistencia
    {
        /// <summary>
        /// método que a partir da lista persiste os dados no arquivo dos veículos que estão na garagem
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        public static void gravarNoArquivoEntrada(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosEntrada.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada);
                escritor.Flush();
            }
            escritor.Close();
        }

        /// <summary>
        /// método que a partir da lista persiste os dados no arquivo dos veículos que passaram pela garagem
        /// </summary>
        /// <param name="lista">lsita de veículos</param>
        public static void gravarNoArquivoSaida(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

            foreach (Veiculo i in lista)
            {                
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada + ";" + i.DataSaida + ";" + i.HoraSaida + ";" + i.TempoPermanecia + ";" + i.ValorCobrado);
                escritor.Flush();
            }
            escritor.Close();
        }

        /// <summary>
        /// método que popula a lista de veículos de estão na garagem a partir do arquivo base
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        public static void lerArquivoEntrada(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("veiculosEntrada.dat");
            string linha;
            string[] vetorDados; 

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");
                lista.Add(new Veiculo(vetorDados[0], vetorDados[1], vetorDados[2]));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        /// <summary>
        /// método que popula a lista de veículos de passaram pela garagem a partir do arquivo base
        /// </summary>
        /// <param name="lista">lista veículos</param>
        public static void lerArquivoSaida(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("veiculosSaida.dat");
            string linha;
            string[] vetorDados;

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");
                lista.Add(new Veiculo(vetorDados[0], vetorDados[1], vetorDados[2], vetorDados[3], 
                    vetorDados[4], int.Parse(vetorDados[5]), double.Parse(vetorDados[6])));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }
    }
}
