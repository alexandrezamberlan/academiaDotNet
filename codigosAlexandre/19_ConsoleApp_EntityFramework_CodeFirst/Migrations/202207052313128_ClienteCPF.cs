namespace _19_ConsoleApp_EntityFramework_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteCPF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "CPF");
        }
    }
}
