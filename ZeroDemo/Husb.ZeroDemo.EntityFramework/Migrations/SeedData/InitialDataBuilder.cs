using Husb.ZeroDemo.EntityFramework;

namespace Husb.ZeroDemo.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly ZeroDemoDbContext _context;

        public InitialDataBuilder(ZeroDemoDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
