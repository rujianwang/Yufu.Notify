using System.Collections.Generic;
using Abp.AutoMapper;
using AutoMapper;
using Yufu.Notify.Entities;
using Yufu.Notify.Enums;
using Yufu.Notify.Shared.WeChatTemplateData.Dto;

namespace Yufu.Notify.Services
{
  public class WebApiAppService : NotifyAppServiceBase, IWebApiAppService
  {
    private readonly INotifyWeChatAppService _notifyWeChatAppService;

    public WebApiAppService(INotifyWeChatAppService notifyWeChatAppService)
    {
      _notifyWeChatAppService = notifyWeChatAppService;
    }

    public NotifyWeChatQueueDto Get(int id)
    {
      var entity = _notifyWeChatAppService.QueueGet(id);
      return entity.MapTo<NotifyWeChatQueueDto>();
    }

    public void PostCreateNotifyWeChatQueue(NotifyWeChatQueueDto dto)
    {
      var entity = dto.MapTo<NotifyWeChatQueue>();
      entity.QueueStatus = QueueStatus.Wait;
      _notifyWeChatAppService.QueueSave(entity);
    }
  }
}