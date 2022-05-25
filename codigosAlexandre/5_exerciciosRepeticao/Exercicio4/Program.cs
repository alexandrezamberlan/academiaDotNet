// Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
// (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
// Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.


string voto; //ZECA, JOAO, BRANCO
int totalVotosZeca = 0;
int totalVotosJoao = 0;
int totalVotosBranco = 0;

do {
    Console.Clear();
    Console.Write("Digite o nome do seu candidato, ou BRANCO, ou FIM para encerrar: ");
    voto = Console.ReadLine().ToUpper();

    switch  (voto) {
        case "JOAO" :
            totalVotosJoao++;
            break;
        case "ZECA" :
            totalVotosZeca++;
            break;
        case "BRANCO" :
            totalVotosBranco++;
            break;
        case "FIM":
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Candidato inexistente");
            break;
    }
    Console.WriteLine("Obrigado por votar nessas eleições");
    Console.ReadKey();
} while (voto != "FIM");

Console.WriteLine("Total de votos para o Zeca: " + totalVotosZeca);
Console.WriteLine("Total de votos para o João: " + totalVotosJoao);
Console.WriteLine("Total de votos em Branco: " + totalVotosBranco);