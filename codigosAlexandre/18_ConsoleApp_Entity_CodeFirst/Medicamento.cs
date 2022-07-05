using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ConsoleApp_Entity_CodeFirst
{
    [Table("Medicamentos")]
    public class Medicamento
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }    
        public string Descricao { get; set; }


        public Medicamento()
        {

        }
        public Medicamento(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
