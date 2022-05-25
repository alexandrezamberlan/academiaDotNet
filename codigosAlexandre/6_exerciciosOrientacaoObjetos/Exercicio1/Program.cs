//#1
//Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10)
//de três personagens. 
//O programa deverá informar o nome do personagem que possuir o maior poder.

//Regras que deverão ser seguidas para a implementação do algoritmo:

//É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades 
//(características) um nome e um poder.
//A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e o 
//poder do personagem em questão.
//Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), 
//um que não recebe parâmetro algum e outro que irá receber o nome e o poder de um personagem


using Exercicio1;

List<Personagem> listaPersonagens = new List<Personagem>(); 

listaPersonagens.Add(new Personagem("Legolas", 700));
listaPersonagens.Add( new Personagem("Gandalf", 1000) );
listaPersonagens.Add(new Personagem("Frodo", 200));
listaPersonagens.Add(new Personagem("Saruman", 2000));

Personagem.mostrarMaisPoderoso(listaPersonagens);

Console.WriteLine();

Console.WriteLine("O mais poderoso é " + Personagem.pegarMaisPoderoso(listaPersonagens));