namespace _18_ConsoleApp_Entity_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_18_ConsoleApp_Entity_CodeFirst.PacienteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "_18_ConsoleApp_Entity_CodeFirst.PacienteContext";
        }

        protected override void Seed(_18_ConsoleApp_Entity_CodeFirst.PacienteContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
