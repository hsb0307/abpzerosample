using System.Collections.Generic;
using System.Collections.ObjectModel;
using ModuleZeroSampleProject.EntityFramework;
using ModuleZeroSampleProject.Migrations.Data;

namespace ModuleZeroSampleProject.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ModuleZeroSampleProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ModuleZeroSampleProject";
        }

        protected override void Seed(ModuleZeroSampleProjectDbContext context)
        {
            new InitialDataBuilder().Build(context);
        }
    }
}
