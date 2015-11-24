using System.Data.Entity.Migrations;
using Husb.Community.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Husb.Community.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Community.EntityFramework.CommunityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Community";
        }

        protected override void Seed(Community.EntityFramework.CommunityDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
