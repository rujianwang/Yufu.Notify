using Abp.Web.Mvc.Controllers;

namespace Yufu.Notify.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class NotifyControllerBase : AbpController
    {
        protected NotifyControllerBase()
        {
            LocalizationSourceName = NotifyConsts.LocalizationSourceName;
        }
    }
}