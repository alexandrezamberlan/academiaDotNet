// See https://aka.ms/new-console-template for more information
using _18_ConsoleApp_Entity_CodeFirst;

using (var contexto = new PacienteContext())
{
    Console.WriteLine("Inciando o programa!!");
    var quantidade_pacientes = contexto.Pacientes.Count();
    var quantidade_medicamentos = contexto.Medicamentos.Count();

    //chamando o segundo construtor
    //contexto.Pacientes.Add(new Paciente("Alexandre", "alexz@ufn.edu.br"));

    //chamando o primeiro construtor 
    //contexto.Pacientes.Add(new Paciente() { Nome = "Sofia", Email = "sofia@ufn.edu.br" });

    contexto.Medicamentos.Add(new Medicamento("Insulina Lantus", "Insulina de longa duração"));

    contexto.Pacientes.First().CPF = "0909090909";
    
    contexto.SaveChanges();
    
    Console.WriteLine("Quantidade de pacientes: " + quantidade_pacientes);
    Console.WriteLine("Quantidade de materiais: " + quantidade_medicamentos);

    foreach (var i in contexto.Pacientes)
    {
        Console.WriteLine("Nome: " + i.Nome + " - " + i.Email + " - " + i.CPF );
    }    
}
