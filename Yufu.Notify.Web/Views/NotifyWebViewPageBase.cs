using Abp.Web.Mvc.Views;

namespace Yufu.Notify.Web.Views
{
    public abstract class NotifyWebViewPageBase : NotifyWebViewPageBase<dynamic>
    {

    }

    public abstract class NotifyWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected NotifyWebViewPageBase()
        {
            LocalizationSourceName = NotifyConsts.LocalizationSourceName;
        }
    }
}