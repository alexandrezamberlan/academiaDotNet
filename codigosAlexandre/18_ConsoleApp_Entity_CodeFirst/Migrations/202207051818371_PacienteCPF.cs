namespace _18_ConsoleApp_Entity_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacienteCPF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pacientes", "CPF");
        }
    }
}
