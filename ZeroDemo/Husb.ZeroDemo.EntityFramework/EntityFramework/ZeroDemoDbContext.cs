using System.Data.Common;
using Abp.Zero.EntityFramework;
using Husb.ZeroDemo.Authorization.Roles;
using Husb.ZeroDemo.MultiTenancy;
using Husb.ZeroDemo.Users;

namespace Husb.ZeroDemo.EntityFramework
{
    public class ZeroDemoDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ZeroDemoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ZeroDemoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ZeroDemoDbContext since ABP automatically handles it.
         */
        public ZeroDemoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ZeroDemoDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
