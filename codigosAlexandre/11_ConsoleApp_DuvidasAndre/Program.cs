// See https://aka.ms/new-console-template for more information
using ConsoleApp_DuvidasAndre;

Console.WriteLine("Hello, World!");

int numero;

Console.WriteLine("Digite um número inteiro");
numero = int.Parse(Console.ReadLine());

//par ou impar
string resposta = Util.parOuImpar(numero);
Console.WriteLine(resposta);

//primo ou nao
Console.WriteLine(Util.primo(numero));

//mostrar todos os numeros de 0 até ele
Util.mostrarTodosAntes(numero);
