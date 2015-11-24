using Husb.Community.EntityFramework;

namespace Husb.Community.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly CommunityDbContext _context;

        public InitialDataBuilder(CommunityDbContext context)
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
