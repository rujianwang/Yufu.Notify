using System.Collections.Generic;
using System.Configuration;
using Abp.AutoMapper;
using AutoMapper;
using Senparc.Weixin;
using Senparc.Weixin.MP.CommonAPIs;
using Yufu.Notify.Entities;
using Yufu.Notify.Enums;
using Yufu.Notify.Services.IServices;
using Yufu.Notify.Shared.App.Dto;
using Yufu.Notify.Shared.WeChatTemplateData.Dto;

namespace Yufu.Notify.Services
{
  public class WebApiAppService : NotifyAppServiceBase, IWebApiAppService
  {
    private readonly INotifyWeChatAppService _notifyWeChatAppService;
    private readonly IAppAppService _appAppService;

    public WebApiAppService(
      INotifyWeChatAppService notifyWeChatAppService, 
      IAppAppService appAppService)
    {
      _notifyWeChatAppService = notifyWeChatAppService;
      _appAppService = appAppService;
    }

    //public NotifyWeChatQueueDto Get(int id)
    //{
    //  var entity = _notifyWeChatAppService.QueueGet(id);
    //  return entity.MapTo<NotifyWeChatQueueDto>();
    //}

    public void PostCreateNotifyWeChatQueue(NotifyWeChatQueueDto dto)
    {
      var queue = dto.MapTo<NotifyWeChatQueue>();
      queue.QueueStatus = QueueStatus.Wait;
      _notifyWeChatAppService.QueueSave(queue);
      var config = _notifyWeChatAppService.ConfigGet(dto.NotifyApplicationId);
      var accessToken = AccessTokenContainer.TryGetAccessToken(config.AppId, config.Appsecret);
      var result = _notifyWeChatAppService.Send(accessToken, queue.Body);
      if (result.errcode == ReturnCode.请求成功)
      {
        queue.QueueStatus = QueueStatus.Success;
      }
      else
      {
        queue.QueueStatus = QueueStatus.Fail;
      }
      queue.QueueStatusCode = result.errcode.ToString();
      _notifyWeChatAppService.QueueSave(queue);
    }

    public void PostCreateNotifyAppQueue(NotifyAppQueueDto dto)
    {
      var queue = dto.MapTo<NotifyAppQueue>();
      queue.QueueStatus = QueueStatus.Wait;
      _appAppService.QueueSave(queue);
      _appAppService.Push(queue);
    }
  }
}