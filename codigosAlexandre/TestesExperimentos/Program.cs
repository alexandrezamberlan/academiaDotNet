string dataEntrada;
string horaEntrada;

string dataSaida;
string horaSaida;


void gerarDataHora(string tipo) {
    DateTime dateTime = DateTime.Now;
    string[] vetorDados = dateTime.ToString().Split(' ');
    switch (tipo) {
        case "entrada":
                dataEntrada = vetorDados[0];
                horaEntrada = vetorDados[1];
                break;
        case "saida":
                dataSaida = vetorDados[0];
                horaSaida = vetorDados[1];
                break;
        default:
            break;
    }    
}




// gerarDataHora("entrada");
// Console.WriteLine("Entrada: " + dataEntrada + "||" + horaEntrada);

// gerarDataHora("saida");
// Console.WriteLine("Saida: " + dataSaida + "||" + horaSaida);
// double resultado = (double)121 / 60;
// Console.WriteLine(resultado);

// Console.WriteLine(Math.Ceiling(resultado));


DateTime dataHoraEntrada = DateTime.Now;

Console.ReadLine();

DateTime dataHoraSaida = DateTime.Now;

Console.WriteLine(dataHoraSaida - dataHoraEntrada);


