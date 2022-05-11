//Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. 
//Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
//na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. 

//Caso contrário, mostre uma mensagem indicando que os dois times irão se
//enfrentar novamente em um novo jogo.

//ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
//ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
//plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.


string timeCasa;
string timeVisitante;

int golsTimeCasa;
int golsTimeVisitante;

Console.Write("Time da casa: ");
timeCasa = Console.ReadLine();

Console.Write("Time visitante: ");
timeVisitante = Console.ReadLine();

Console.Write("Gols feitos pelo time da casa: ");
golsTimeCasa = int.Parse(Console.ReadLine());

Console.Write("Gols feitos pelo time da visitante: ");
golsTimeVisitante = int.Parse(Console.ReadLine());

if (golsTimeVisitante > golsTimeCasa && (golsTimeVisitante - golsTimeCasa) >= 2)
{
    Console.WriteLine($"{timeVisitante} já está classificado, pois ganhou com uma diferença de 2 gols!");
} else
{
    Console.WriteLine("Novo jogo.....");

    string tmp = timeCasa;
    timeCasa = timeVisitante;
    timeVisitante = tmp;

    Console.WriteLine($"Time da casa agora é {timeCasa}");

    Console.WriteLine($"Time visitante agora é {timeVisitante} ");

    Console.Write("Gols feitos pelo time da casa: ");
    golsTimeCasa = int.Parse(Console.ReadLine());

    Console.Write("Gols feitos pelo time da visitante: ");
    golsTimeVisitante = int.Parse(Console.ReadLine());

    if (golsTimeCasa > golsTimeVisitante)
    {
        Console.WriteLine($"{timeCasa} passou para próxima fase!!");
    } else
    {
        Console.WriteLine($"{timeVisitante} passou para próxima fase!!");
    }
}


