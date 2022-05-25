//Problema das listagens dos alunos (disciplinas de Estruturas de Dados e Linguagem de Programação)
//        -Arquivos.txt com nomes dos matriculados (matricula; nome; email)

//        Listas -> List(Count, Add(), AddRange(), Remove(), Contains())
//        Console -> Console(WriteLine(), ReadLine(), ReadKey(), Clear())
//        Arquivo Texto -> StreamReader (ReadLine(), StreamReader(), EndOfStream(), Close())
//        Aluno -> criar a classe aluno -> seus atributos e seus serviços
//        Utilidades -> criar a classe Util -> com serviços comuns de arquivo e listas


using ProblemaDasDisciplinas;

List<Aluno> listaDisciplina1 = new List<Aluno>();
List<Aluno> listaDisciplina2 = new List<Aluno>();

string opcao = "";

do
{
    Console.Clear();
    Console.WriteLine("1 - Carregar listas de disciplinas");
    Console.WriteLine("2 - Exibir as listas de disciplinas");
    Console.WriteLine("3 - Mostrar alunos comuns nas disciplinas");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Carregar listas de disciplinas");
            Util.carregarListas(listaDisciplina1, listaDisciplina2);
            break;
        case "2":
            Console.WriteLine("Exibir listas de disciplinas");
            Util.exibirLista("Lista da disciplina 1", listaDisciplina1);
            Util.exibirLista("Lista da disciplina 2", listaDisciplina2);
            break;
        default:
            break;
    }
    Console.Write("Pressiona algo para continuar!"); Console.ReadKey();
} while (opcao != "4");

