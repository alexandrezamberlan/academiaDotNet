//Exercícios desafio de string
//Fazer um programa que receba  o nome completo de uma pessoa e
//exiba em maiúsculo o primeiro nome e o último sobrenome dessa pessoa.

//Fazer um programa que receba o nome completo de uma pessoa e o
//exiba abreviado

/// <summary>
/// armazena o nome completo informado pelo usuario
/// </summary>
string nomeCompleto;

/// <summary>
/// vetor de string que recebe o split das palavras do nomeCompleto
/// </summary>
string[] palavras;

/// <summary>
/// armazena o primeiro nome do nome completo
/// </summary>
string primeiroNome;

/// <summary>
/// armazena o último sobrenome de um nome completo
/// </summary>
string ultimoSobreNome;


//receber um nome completo
Console.Write("Digite um nome completo: ");
nomeCompleto = Console.ReadLine();
nomeCompleto = nomeCompleto.ToUpper();

//splitar o nome completo por espaço em branco
palavras = nomeCompleto.Split(" ");

primeiroNome = palavras[0];
ultimoSobreNome = palavras[ palavras.Length - 1 ];

Console.WriteLine("Seu primeiro nome: " + primeiroNome);
Console.WriteLine("Seu último sobrenome: " + ultimoSobreNome);




