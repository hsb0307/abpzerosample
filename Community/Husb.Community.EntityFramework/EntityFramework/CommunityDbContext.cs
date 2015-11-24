using System.Data.Common;
using Abp.Zero.EntityFramework;
using Husb.Community.Authorization.Roles;
using Husb.Community.MultiTenancy;
using Husb.Community.Users;

namespace Husb.Community.EntityFramework
{
    public class CommunityDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public CommunityDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in CommunityDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of CommunityDbContext since ABP automatically handles it.
         */
        public CommunityDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public CommunityDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
