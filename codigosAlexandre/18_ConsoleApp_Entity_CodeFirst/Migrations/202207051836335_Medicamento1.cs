namespace _18_ConsoleApp_Entity_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Medicamento1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Medicamentoes", newName: "Medicamento");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Medicamento", newName: "Medicamentoes");
        }
    }
}
