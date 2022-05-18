using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto

try
{
    List<String> frasesLidas = new List<string>();
    String nomeArquivo;
    Console.Write("Digite o nome do arquivo que deseja ler: ");
    nomeArquivo = Console.ReadLine();
    StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura

    do
    {
        frasesLidas.Add(leitor.ReadLine());

    } while (!leitor.EndOfStream);

    leitor.Close(); //fecha o objeto que representa o arquivo

    for (int i = 0; i < frasesLidas.Count; i++)
    {
        Console.WriteLine(frasesLidas[i]);
    }
}
catch (IOException e)
{
    Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
}