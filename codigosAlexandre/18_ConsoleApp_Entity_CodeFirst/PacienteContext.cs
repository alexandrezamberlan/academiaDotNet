using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _18_ConsoleApp_Entity_CodeFirst
{
    public class PacienteContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }   
    }
}
