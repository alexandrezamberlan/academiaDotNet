using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto

try
{
    string frase;
    string nomeArquivo;
    StreamWriter escritor;

    Console.Write("Digite o nome do arquivo que deseja gravar: ");
    nomeArquivo = Console.ReadLine();
    escritor = new StreamWriter(nomeArquivo); //abre o arquivo para escrita

    do
    {
        Console.Write("Digite uma frase ou 'sair' para encerrar programa: ");
        frase = Console.ReadLine();
        frase.ToLower(); //frase.toUpper();
        if (frase.Equals("sair"))
        {
            break;
        }
        escritor.WriteLine(frase); //literalmente escreve no arquivo
        escritor.Flush(); //garante depois de cada frase digitada que vá para o arquivo
    } while (true);
    escritor.Close(); //fecha o objeto que representa o arquivo
}
catch (IOException e)
{
    Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
}