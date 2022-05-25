// 3) Fazer um programa parecido com o número 1, porém, os dados devem vir de um arquivo texto (um valor abaixo do outro).

// Também sugere-se usar um menu

// MENU
// 1 - Abrir arquivo com dados de glicemia e popular lista
// 2 - Exibir lista
// 3 - Mostrar medidas centrais (média, valores min e max e mediana)
// 4 - Sair
// Opção: ____

// listaGlicemia é um objeto da classe List, logo tem atributos e métodos vindos da classe: Count; Add(); Contains()
List<int> listaGlicemia = new List<int>();

// opcao é um objeto da classe string, logo tem atributos e métodos vindos da classe: ToUpper(); Length; Split()
string opcao = "";
do {
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Abrir arquivo com dados de glicemia e popular lista");
    Console.WriteLine("2 - Exibir lista");
    Console.WriteLine("3 - Mostrar medidas centrais (média, valores min e max e mediana)");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch  (opcao) {
        case "1":
            //gerar lista aleatoria
            Console.WriteLine("Abrir arquivo com dados de glicemia");
            try //tratamento de exceções
            {
                String nomeArquivo;
                Console.Write("Digite o nome do arquivo com valores glicemicos que deseja ler: ");
                nomeArquivo = Console.ReadLine();
                StreamReader leitor = new StreamReader(nomeArquivo); //abre o arquivo para leitura
                //StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura

                do
                {
                    listaGlicemia.Add(int.Parse( leitor.ReadLine() ));

                } while (!leitor.EndOfStream);

                leitor.Close(); //fecha o objeto que representa o arquivo
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
            }
            break;
        case "2":
            //exibir lista aleatoria
            Console.WriteLine("Exibindo a lista de valores glicêmicos");
            if (listaGlicemia.Count == 0) {
                Console.WriteLine("Lista Vazia!");
            } else {
                for (int i = 0; i < listaGlicemia.Count; i++)
                {
                    Console.WriteLine(listaGlicemia[i]);
                }
                // foreach (int i in listaGlicemia)
                // {
                //     Console.WriteLine(i);
                // }
            }
            break;
        case "3":
            Console.WriteLine("Exibindo as medidas centrais da lista");
            if (listaGlicemia.Count == 0) {
                Console.WriteLine("Lista Vazia!");
            } else {
                //mostrar medidas centrais
                float media;
                int min;
                int max;
                float mediana;

                List<int> listaTmp = new List<int>();
                listaTmp.AddRange(listaGlicemia);
                listaTmp.Sort();
                min = listaTmp[0];
                max = listaTmp[ listaTmp.Count - 1 ];
                int soma = 0;
                foreach (int i in listaTmp){
                    //soma = soma + i;
                    soma += i;
                }
                media = soma / listaTmp.Count;

                //regra de negócio para cálculo da mediana
                int meio = (int)listaTmp.Count / 2;
                if (listaTmp.Count % 2 != 0) { //lista tem tamanho impar
                    mediana = listaTmp[meio];
                } else { //lista tem tamanho par
                    mediana  = listaTmp[meio] + listaTmp[meio - 1] / 2;
                }
                
                Console.WriteLine("A mediana de valores da lista é: " + mediana);
                Console.WriteLine("A média de valores da lista é: " + media);
                Console.WriteLine("O valor min da lista é: " + min);
                Console.WriteLine("O valor max da lista é: " + max);
            }
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


