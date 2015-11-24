using Abp.Web.Mvc.Views;

namespace Husb.Community.Web.Views
{
    public abstract class CommunityWebViewPageBase : CommunityWebViewPageBase<dynamic>
    {

    }

    public abstract class CommunityWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CommunityWebViewPageBase()
        {
            LocalizationSourceName = CommunityConsts.LocalizationSourceName;
        }
    }
}