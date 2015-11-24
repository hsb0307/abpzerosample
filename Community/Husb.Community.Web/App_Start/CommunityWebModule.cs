using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Modules;
using Abp.Zero.Configuration;
using Husb.Community.Api;
using Abp.Localization;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using System.Web;

namespace Husb.Community.Web
{
    [DependsOn(typeof(CommunityDataModule), typeof(CommunityApplicationModule), typeof(CommunityWebApiModule))]
    public class CommunityWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            Configuration.Localization.Languages.Add(new LanguageInfo("zh-CN", "简体中文", "famfamfam-flag-cn"));

            ////Add a localization source
            //Configuration.Localization.Sources.Add(
            //    new DictionaryBasedLocalizationSource(
            //        "Community",
            //        new XmlFileLocalizationDictionaryProvider(
            //            HttpContext.Current.Server.MapPath("~/Localization/Community")
            //            )
            //        )
            //    );
            //Enable database based localization
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<CommunityNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
