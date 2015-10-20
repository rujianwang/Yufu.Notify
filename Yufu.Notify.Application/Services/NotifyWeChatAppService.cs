using Abp.Domain.Repositories;
using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage;
using Yufu.Notify.Application;
using Yufu.Notify.Entities;

namespace Yufu.Notify.Services
{
  public class NotifyWeChatAppService : NotifyAppServiceBase, INotifyWeChatAppService
  {
    private readonly IRepository<NotifyApplication> _notifyApplicationRepository;
    private readonly IRepository<NotifyWeChatQueue> _notifyWeChatQueueRepository;

    public NotifyWeChatAppService(IRepository<NotifyApplication> notifyApplicationRepository,
      IRepository<NotifyWeChatQueue> notifyWeChatQueueRepository)
    {
      _notifyApplicationRepository = notifyApplicationRepository;
      _notifyWeChatQueueRepository = notifyWeChatQueueRepository;
    }


    public void QueueSave(NotifyWeChatQueue entity)
    {
      _notifyWeChatQueueRepository.InsertOrUpdate(entity);
    }

    public NotifyWeChatQueue QueueGet(int id)
    {
      return _notifyWeChatQueueRepository.FirstOrDefault(id);
    }

    public void QueueDelete(int id)
    {
      _notifyWeChatQueueRepository.Delete(id);
    }

    public SendTemplateMessageResult Send(string accessToken, string data)
    {
      var result = YufuWeChatHelper.SendTemplateMessage(accessToken, data);
      return result;
    }
  }
}