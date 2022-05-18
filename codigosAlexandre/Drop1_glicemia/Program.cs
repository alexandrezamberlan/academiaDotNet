// 1) Fazer um programa em VS que gere uma lista com n valores randômicos e inteiros para glicemia (entre 45 a 500). 
// O progrma deve calcular média, valor mínimo, valor máximo e mediana.
// Sugere-se criar um menu como:

// MENU
// 1 - Gerar lista
// 2 - Exibir lista
// 3 - Mostrar medidas centrais (média, valores min e max e mediana)
// 4 - Sair
// Opção: ____

// Observação, toda vez que a opção 1 for acionada, o usuário deve definir quantos números serão gerados na lista

// listaGlicemia é um objeto da classe List, logo tem atributos e métodos vindos da classe: Count; Add(); Contains()
List<int> listaGlicemia = new List<int>();

// opcao é um objeto da classe string, logo tem atributos e métodos vindos da classe: ToUpper(); Length; Split()
string opcao = "";
do {
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Gerar lista");
    Console.WriteLine("2 - Exibir lista");
    Console.WriteLine("3 - Mostrar medidas centrais (média, valores min e max e mediana)");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch  (opcao) {
        case "1":
            //gerar lista aleatoria
            Console.WriteLine("Lista sendo populada");
            int quantidadeNumeros;
            Console.Write("Quantos números quer gerar? ");
            quantidadeNumeros = int.Parse( Console.ReadLine() );
            Random gerador = new Random();
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                listaGlicemia.Add( gerador.Next(45,500) );
            }
            break;
        case "2":
            //exibir lista aleatoria
            break;
        case "3":
            //mostrar medidas centrais
            break;
        case "4":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "4");

