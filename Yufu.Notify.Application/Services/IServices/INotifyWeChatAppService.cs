using Abp.Application.Services;
using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage;
using Yufu.Notify.Entities;
using Yufu.Notify.Shared.WeChatTemplateData;

namespace Yufu.Notify.Services
{
  public interface INotifyWeChatAppService : IApplicationService
  {
    void QueueSave(NotifyWeChatQueue entity);
    NotifyWeChatQueue QueueGet(int id);
    void QueueDelete(int id);


    NotifyWeChatConfig ConfigGet(int applicationId);

    SendTemplateMessageResult Send(string accessToken, string data);
  }
}