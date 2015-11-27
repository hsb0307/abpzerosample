using System.Data.Entity.Migrations;
using Husb.ZeroDemo.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Husb.ZeroDemo.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ZeroDemo.EntityFramework.ZeroDemoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ZeroDemo";
        }

        protected override void Seed(ZeroDemo.EntityFramework.ZeroDemoDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
