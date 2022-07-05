using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _18_ConsoleApp_Entity_CodeFirst
{
    public class Paciente
    {
        public int Id { get; set; } 
        public string Nome { get; set; }    
        public string Email { get; set; }


        public Paciente()
        {

        }
        public Paciente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
