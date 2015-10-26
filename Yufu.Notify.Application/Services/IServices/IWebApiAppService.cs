using Abp.Application.Services;
using Yufu.Notify.Shared.App.Dto;
using Yufu.Notify.Shared.WeChatTemplateData.Dto;

namespace Yufu.Notify
{
  public interface IWebApiAppService : IApplicationService
  {
    //NotifyWeChatQueueDto Get(int id);

    void PostCreateNotifyWeChatQueue(NotifyWeChatQueueDto dto);

    void PostCreateNotifyAppQueue(NotifyAppQueueDto dto);
  }
}