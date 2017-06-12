using System.Data.Entity;
using System.Data.Entity.Migrations;


namespace Model.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Model.Models.DB_SAUDEContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Model.Models.DB_SAUDEContext context)
        {

        }
    }
}
