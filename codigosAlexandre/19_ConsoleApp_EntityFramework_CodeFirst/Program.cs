// See https://aka.ms/new-console-template for more information
using _19_ConsoleApp_EntityFramework_CodeFirst;

using (var contexto = new ClienteContext())
{
    string opcao;
    do
    {
        Console.WriteLine("1 - Cadastrar cliente");
        Console.WriteLine("2 - Listar clientes");
        Console.WriteLine("3 - Remover cliente");
        Console.WriteLine("4 - Sair");
        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                //cadastrar um cliente
                Console.Write("Digite nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite email: ");
                string email = Console.ReadLine();

                Console.Write("Digite CPF: ");
                string cpf = Console.ReadLine();

                contexto.Clientes.Add(new Cliente(nome, email, cpf));
                contexto.SaveChanges();
                break;
            case "2":
                //listar clientes
                Console.WriteLine("Clientes cadastrados!");
                Console.WriteLine("====================");
                foreach (var i in contexto.Clientes)
                {
                    Console.WriteLine("Nome: " + i.Nome);
                    Console.WriteLine("Email: " + i.Email);
                    Console.WriteLine("CPF: " + i.CPF);
                    Console.WriteLine("====================");
                }
                break;
            case "3":
                //remover um cliente
                Console.Write("Digite email para busca: ");
                string emailPesquisa = Console.ReadLine();

                var resultado = contexto.Clientes.Where(p => p.Email.Equals(emailPesquisa)).ToList();
                
                if (resultado.Count > 0)
                {
                    Console.WriteLine("Achou..... " + resultado[0].Nome);

                    contexto.Clientes.Remove(resultado[0]);
                    contexto.SaveChanges();
                } else
                {
                    Console.WriteLine("Cliente não localizado por este email!!"); ;
                }
                break;
            case "4":                
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    } while (opcao != "4");
}

