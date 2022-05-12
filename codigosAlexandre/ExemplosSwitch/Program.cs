// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplificando o uso de SWITCH");

/// <summary>
/// armazena a sigla de um estado, convertido em maiúsculo
/// </summary>
//string siglaEstado;

//Console.Write("Digite a sigla de um estado brasileiro: ");
//siglaEstado = Console.ReadLine().ToUpper();

//switch (siglaEstado)
//{
//    case "BA":
//        Console.WriteLine("Estado da Bahia");
//        break;
//    case "ES":
//        Console.WriteLine("Estado da Espírito Santo");
//        break;
//    case "MG":
//        Console.WriteLine("Estado de Minas Gerais");
//        outras instruções
//        break;
//    case "PE":
//        Console.WriteLine("Estado de Pernambuco");
//        break;
//    case "PI":
//        Console.WriteLine("Estado do Piauí");
//        break;
//    case "PR":
//        Console.WriteLine("Estado do Paraná");
//        break;
//    case "RJ":
//        Console.WriteLine("Estado do Rio de Janeiro");
//        break;
//    case "RS":
//        Console.WriteLine("Estado do Rio Grande do Sul");
//        break;
//    case "SC":
//        Console.WriteLine("Estado de Santa Catarina");
//        break;
//    case "SP":
//        Console.WriteLine("Estado de São Paulo");
//        break;
//    default:
//        Console.WriteLine("Sigla do Estado inválida ou não cadastrada!");
//        break;
//}



string indiceSemana;
string diaSemana = ""; //iniciando com vazio

do
{
    Console.Write("Digite o índice/número referente ao dia da semana: ");
    indiceSemana = Console.ReadLine();

    switch (indiceSemana)
    {
        case "1":
            diaSemana = "Domingo";
            break;
        case "2":
            diaSemana = "Segunda-feira";
            break;
        case "3":
            diaSemana = "Terça-feira";
            break;
        case "4":
            diaSemana = "Quarta-feira";
            break;
        case "5":
            diaSemana = "Quinta-feira";
            break;
        case "6":
            diaSemana = "Sexta-feira";
            break;
        case "7":
            diaSemana = "Sábado";
            break;
        default:
            Console.WriteLine("Índice da semana inexistente!");
            break;
    }
} while (diaSemana == "");

if (diaSemana != "")
{
    Console.WriteLine($"Hoje é {diaSemana}");
}


//string opcao;

//do
//{
//    Console.WriteLine("1 - Cadastrar música");
//    Console.WriteLine("2 - Exibir músicas cadastradas");
//    Console.WriteLine("3 - Pesquisar música");
//    Console.WriteLine("4 - Sair");
//    Console.Write("Opção: ");

//    opcao = Console.ReadLine();
//    switch (opcao)
//    {
//        case "1":
//            Console.WriteLine("Você está entrando no menu de cadastro de música");
//            break;
//        case "2":
//            Console.WriteLine("Você está entrando no menu de exibição de músicas");
//            break;
//        case "3":
//            Console.WriteLine("Você está entrando no menu de pesquisa por música");
//            break;
//        case "4":
//            Console.WriteLine("Obrigado por usar o sistema!");
//            break;
//        default:
//            Console.WriteLine("Opção inválida!");
//            break;
//    }
//} while (opcao != "4");






