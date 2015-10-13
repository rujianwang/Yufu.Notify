using Abp.Application.Services;

namespace Yufu.Notify
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class NotifyAppServiceBase : ApplicationService
    {
        protected NotifyAppServiceBase()
        {
            LocalizationSourceName = NotifyConsts.LocalizationSourceName;
        }
    }
}