//Manipulando strings com alguns comandos/instruções/métodos/funções

/*
Length
ToUpper()
ToLower()
Contains()
Split()
*/


string frase;
string fraseMaiusculo;
string fraseMinusculo;
int quantidadeCaracteres;
string palavraPesquisa;

Console.Write("Digite uma frase qualquer: ");
frase = Console.ReadLine();

fraseMaiusculo = frase.ToUpper(); //converte para maiusculo
fraseMinusculo = frase.ToLower(); //converte para minusculo


Console.WriteLine("Você digitou: " + frase);

quantidadeCaracteres = frase.Length; //armazena a quantidade de caracteres
Console.WriteLine("A frase possui " + quantidadeCaracteres + " caracteres");
Console.WriteLine("A frase em maiúsculo: " + fraseMaiusculo);
Console.WriteLine("A frase em minúsculo: " + fraseMinusculo);

Console.Write("Digite uma palavra para procurar na frase: ");
palavraPesquisa = Console.ReadLine();

Console.WriteLine("Se encontrou == True; Caso contrário == False. Resposta: " + frase.Contains(palavraPesquisa));


Console.WriteLine("Frase splitada!");
//frase = alexandre de oliveira zamberlan
string[] palavras = fraseMaiusculo.Split(" "); //separou em um vetor as palavras de frase em que o critério foi espaço em branco
//               0        1      2         3
//palavras = alexandre | de | oliveira | zamberlan

Console.WriteLine("A ultima palavra digitada foi: " + palavras[  palavras.Length - 1 ]);

