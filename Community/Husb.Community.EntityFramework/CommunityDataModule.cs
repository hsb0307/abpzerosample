using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Husb.Community.EntityFramework;

namespace Husb.Community
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(CommunityCoreModule))]
    public class CommunityDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
