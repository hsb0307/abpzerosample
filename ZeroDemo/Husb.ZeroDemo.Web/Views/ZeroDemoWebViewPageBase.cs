using Abp.Web.Mvc.Views;

namespace Husb.ZeroDemo.Web.Views
{
    public abstract class ZeroDemoWebViewPageBase : ZeroDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class ZeroDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ZeroDemoWebViewPageBase()
        {
            LocalizationSourceName = ZeroDemoConsts.LocalizationSourceName;
        }
    }
}