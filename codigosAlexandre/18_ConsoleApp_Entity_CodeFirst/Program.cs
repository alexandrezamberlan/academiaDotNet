// See https://aka.ms/new-console-template for more information
using _18_ConsoleApp_Entity_CodeFirst;

using (var contexto = new PacienteContext())
{
    Console.WriteLine("Inciando o programa!!");
    var quantidade_pacientes = contexto.Pacientes.Count();

    //chamando o segundo construtor
    contexto.Pacientes.Add(new Paciente("Alexandre", "alexz@ufn.edu.br"));

    //chamando o primeiro construtor 
    //contexto.Pacientes.Add(new Paciente() { Nome = "Sofia", Email = "sofia@ufn.edu.br" });
    
    contexto.SaveChanges();
    
    Console.WriteLine("Feito " + quantidade_pacientes);
}
