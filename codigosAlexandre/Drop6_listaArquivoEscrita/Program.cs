//Programa em VS que recebe emails de um usuário e que são gravados em arquivo.

using Drop6_listaArquivoEscrita;

string opcao = "";
string nomeArquivo = "emails.dat"; //texto puro -> plain text
StreamWriter escritor = new StreamWriter(nomeArquivo, true); //abre o arquivo para escrita e com append
List<Pessoa> listaPessoas = new List<Pessoa>();

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar uma pessoa");
    Console.WriteLine("2 - Exibir pessoas");
    Console.WriteLine("3 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //receber um email e gravar no arquivo
            try
            {
                string nome;
                string email;

                Console.Write("Digite nome: ");
                nome = Console.ReadLine().ToUpper();

                Console.Write("Digite email: ");
                email = Console.ReadLine().ToLower();

                //criar um objeto Pessoa com os valores nome e email
                Pessoa p = new Pessoa(nome, email);

                //verificar se essa dupla já está na lista, logo no arquivo
                bool jaCadastrado = false;
                foreach (Pessoa i in listaPessoas)
                {
                    if (i.email.Equals(email))
                    {
                        Console.WriteLine("Esse email já está no sistema");
                        jaCadastrado = true;
                        break;
                    }
                }
                if (!jaCadastrado)
                {
                    //adicionar o objeto na lista
                    listaPessoas.Add(p);
                    //adicionar o objeto no arquivo
                    escritor.WriteLine(p.nome + ";" + p.email); //literalmente escreve no procurador e em memória
                    escritor.Flush(); //garante depois de cada frase digitada que vá para o arquivo                
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }
            break;
        case "2":
            Console.WriteLine("Exbindo a lista de pessoas");

            foreach (Pessoa i in listaPessoas)
            {
                Console.WriteLine(i.nome + " - " + i.email);
            }

            break;
        case "3":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "3");

escritor.Close(); //fecha o objeto que representa o arquivo
