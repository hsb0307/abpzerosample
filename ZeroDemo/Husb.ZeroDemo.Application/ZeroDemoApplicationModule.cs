using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Husb.ZeroDemo
{
    [DependsOn(typeof(ZeroDemoCoreModule), typeof(AbpAutoMapperModule))]
    public class ZeroDemoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
