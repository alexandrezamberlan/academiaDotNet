using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto
try
{
    String nomeArquivo;
    String fraseLida;

    Console.Write("Digite o nome do arquivo que deseja ler: ");
    nomeArquivo = Console.ReadLine();
    StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura

    fraseLida = leitor.ReadToEnd();
    Console.WriteLine(fraseLida);

    leitor.Close(); //fecha o objeto que representa o arquivo
}
catch (IOException e)
{
    Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
}