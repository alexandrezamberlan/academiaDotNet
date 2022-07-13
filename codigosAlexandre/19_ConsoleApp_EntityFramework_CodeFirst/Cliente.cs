using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConsoleApp_EntityFramework_CodeFirst
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Email { get; set; }

        public string CPF { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email, string cpf)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
        }
    }
}
