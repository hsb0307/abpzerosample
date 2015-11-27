using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Husb.ZeroDemo.EntityFramework;

namespace Husb.ZeroDemo
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ZeroDemoCoreModule))]
    public class ZeroDemoDataModule : AbpModule
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
