// See https://aka.ms/new-console-template for more information
Console.WriteLine("A ideia é trabalhar com métodos/funções de algumas classes importantes: string, Random, DateTime, List");


//Classe string e seus principais métodos/atributos: Length, ToUpper(), ToLower(), Split(), Contains(), IndexOf()
string frase = "Excelente turma de dotNet da Academia Atos";

int tamanhoFrase = frase.Length;
string fraseEmMaiusuculo = frase.ToUpper();
string fraseEmMinusculoa = frase.ToLower();

string[] palavrasNaFrase = frase.Split(" "); //separa cada palavra da frase em uma posicao do vetor palavrasNaFrase


bool estaContido = frase.Contains("Atos"); //retorna se uma substring está ou não contida numa outra string
int posicao = frase.IndexOf("Atos"); //retorna a posição em índice da primeira ocorrênciade uma substring na frase, 


//Classe Random
Random rnd = new Random(); //declarando uma 'variável' chamada rnd e instanciando em memória - new()

int sorteio = rnd.Next(1,11);
Console.WriteLine(sorteio);


char letra = (char)rnd.Next(65, 91); //A..Z 
Console.WriteLine(letra);

//Classe DateTime
DateTime dataLocal = DateTime.Now;
Console.WriteLine(dataLocal.ToString());
string[] dataHora = dataLocal.ToString().Split(" ");

Console.WriteLine("So a data: " + dataHora[0]);
Console.WriteLine("So a hora: " + dataHora[1]);

//Classe List - estrutura de dados que armazena outros objetos de maneira dinâmica

List<string> listaAlunos = new List<string>(); //declarando uma 'variável' chamada listaAluno e instanciando em memória - new()

listaAlunos.Add("Rodrigo");
listaAlunos.Add("Andréa");
listaAlunos.Add("Paulino");
listaAlunos.Add("Leonardo");
listaAlunos.Add("Flávia");
listaAlunos.Add("Leandro");

Console.WriteLine("Tamanho da lista: " + listaAlunos.Count);
Console.WriteLine("Removendo o Leonardo");

Console.WriteLine("Posição do Leonardo na lista: " + listaAlunos.IndexOf("Leonardo"));

listaAlunos.Remove("Leonardo");
Console.WriteLine("Tamanho da lista: " + listaAlunos.Count);

//Console.WriteLine("Removendo todos os elementos da lista");
//listaAlunos.Clear();
//Console.WriteLine("Tamanho da lista: " + listaAlunos.Count);




List<int> listaGlicemia = new List<int>();
listaGlicemia.Add(136);
listaGlicemia.Add(66);
listaGlicemia.Add(78);
listaGlicemia.Add(236);
listaGlicemia.Add(90);
listaGlicemia.Add(100);
listaGlicemia.Add(111);

listaGlicemia.Sort();

Console.WriteLine("Menor medição de glicemia do período: " + listaGlicemia[0]);
Console.WriteLine("Maior medição de glicemia do período: " + listaGlicemia[ listaGlicemia.Count - 1 ]);








