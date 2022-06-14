using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsAppDesafioGaragem
{
    internal class Veiculo
    {
        string placa; // -> 7 caracteres -> verificar jaNaGaragem
        string dataEntrada;
        string horaEntrada;
        string dataSaida;
        string horaSaida;
        int tempoPermanecia; //minutos
        double valorCobrado;        

        /// <summary>
        /// construtor é utilizado na leitura do arquivo de veículos que estão na garagem
        /// </summary>
        /// <param name="placa"> identificação do veículo </param>
        /// <param name="dataEntrada">Data do sistema para a entrada do veículo</param>
        /// <param name="horaEntrada">Hora do sistema para a entrada do veículo</param>
        public Veiculo(string placa, string dataEntrada, string horaEntrada)
        {
            this.Placa = placa;
            this.DataEntrada = dataEntrada;
            this.HoraEntrada = horaEntrada;
        }

        /// <summary>
        /// construtor capturando somente a placa do veículo
        /// </summary>
        /// <param name="placa"></param>
        public Veiculo(string placa)
        {
            this.Placa = placa;
        }

        /// <summary>
        ///  construtor é utilizado na leitura do arquivo de saída com veículos que já passaram pela garagem
        /// </summary>
        /// <param name="placa">Identificação do veículo</param>
        /// <param name="dataEntrada"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="dataSaida"></param>
        /// <param name="horaSaida"></param>
        /// <param name="tempoPermanecia">tempo em minutos</param>
        /// <param name="valorCobrado"></param>
        public Veiculo(string placa, string dataEntrada, string horaEntrada, 
            string dataSaida, string horaSaida, int tempoPermanecia, double valorCobrado) : this(placa, dataEntrada, horaEntrada)
        {
            this.dataSaida = dataSaida;
            this.horaSaida = horaSaida;
            this.tempoPermanecia = tempoPermanecia;
            this.valorCobrado = valorCobrado;
        }

        /// <summary>
        /// metodo que gera a data e a hora para a entrada ou para a saida de um veiculo
        /// </summary>
        /// <param name="tipo"> entrada para gerar a data e hora de entrada; saida para a data e hora de saída</param>
        public void gerarDataHora(string tipo)
        {
            DateTime dateTime = DateTime.Now;
            string[] vetorDados = dateTime.ToString().Split(' ');
            switch (tipo)
            {
                case "entrada":
                    this.DataEntrada = vetorDados[0];
                    this.HoraEntrada = vetorDados[1];
                    break;
                case "saida":
                    this.DataSaida = vetorDados[0];
                    this.HoraSaida = vetorDados[1];
                    break;
                default:
                    break;
            }
        }  
        
        /// <summary>
        /// metodo que calcula o tempo de permanencia (em minutos) e calcula o valor de cobranca 
        /// </summary>
        /// <param name="valorHora">valor de referencia da hora</param>
        public void realizarCobranca(double valorHora)
        {
            //horaEntrada = "8:14"; -> 8*60+14 = 494
            //horaSaida = "10:15";  -> 10*60+15 = 615
            //descobrindo o tempo em minutos da entrada
            string[] vetorDados = horaEntrada.Split(':');
            int hora = int.Parse(vetorDados[0]);
            int minutos = int.Parse(vetorDados[1]);
            int entrada = hora * 60 + minutos;

            //descobrindo o tempo em minutos da saida
            vetorDados = horaSaida.Split(':');
            hora = int.Parse(vetorDados[0]);
            minutos = int.Parse(vetorDados[1]);
            int saida = hora * 60 + minutos;

            this.TempoPermanecia = saida - entrada;
            double resultado = (double)this.TempoPermanecia / 60;
            double qtdHorasNaGaragem = Math.Ceiling( resultado );

            this.valorCobrado = (int)qtdHorasNaGaragem * valorHora;
        }

        public string Placa { get => placa; set => placa = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string DataSaida { get => dataSaida; set => dataSaida = value; }
        public string HoraSaida { get => horaSaida; set => horaSaida = value; }
        public int TempoPermanecia { get => tempoPermanecia; set => tempoPermanecia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }


        /// <summary>
        /// metodo que procura um veiculo na lista a partir de sua placa
        /// </summary>
        /// <param name="placa">identificação do veículo</param>
        /// <param name="lista">lista de veículos ou de entrada ou de saída</param>
        /// <returns>a posição em que o veículo se encontra na lista, caso contrário, -27</returns>
        public static int localizado(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27; //codigo do ESC, ou seja, veiculo nao localizado
        }

        /// <summary>
        /// metodo que descobre se há espaço ou não na garagem, ou lista de controle da garagem
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        /// <param name="tamanhoGaragem">quantidade de vagas na garagem</param>
        /// <returns></returns>
        public static bool temLugar(List<Veiculo> lista, int tamanhoGaragem)
        {
            return lista.Count < tamanhoGaragem;
        }
    }
}
