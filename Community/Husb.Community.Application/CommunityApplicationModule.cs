using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Husb.Community
{
    [DependsOn(typeof(CommunityCoreModule), typeof(AbpAutoMapperModule))]
    public class CommunityApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
