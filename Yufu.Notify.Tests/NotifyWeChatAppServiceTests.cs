using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Senparc.Weixin;
using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage;
using Senparc.Weixin.MP.CommonAPIs;
using Yufu.Notify.Entities;
using Yufu.Notify.Enums;
using Yufu.Notify.Services;
using Yufu.Notify.Shared.WeChatTemplateData;

namespace Yufu.Notify.Tests
{
  [TestClass]
  public class NotifyWeChatAppServiceTests : YufuTestBase
  {
    private INotifyWeChatAppService _notifyWeChatAppService;

    public NotifyWeChatAppServiceTests()
    {
      _notifyWeChatAppService = LocalIocManager.IocContainer.Resolve<INotifyWeChatAppService>();
    }


    [TestMethod]
    public void TestAdd()
    {
      //var templeteData = new NewBid
      //{
      //  first = new TemplateDataItem("新的竞价提醒"),
      //  remark = new TemplateDataItem("更详细信息，请到恒物流官方网站（http://www.heng56.com）查看！"),
      //  keyword1 = new TemplateDataItem("轮胎30吨 "),
      //  keyword2 = new TemplateDataItem("顺风物流"),
      //  keyword3 = new TemplateDataItem(DateTime.Now.ToString())
      //};
      //var templeteModel = new TempleteModel
      //{
      //  touser = "oau-_jp4FCPggdZs4-6ZQJ2zTiXA",
      //  template_id = "4fMiEbioXo-1iCbttMJtq4REmQfnFJ2cCFu0HL0W_b4",
      //  topcolor = "#FF0000",
      //  url = "http://m.heng56.com",
      //  data = templeteData
      //};

      //var entity = new NotifyWeChatQueue
      //{
      //  Body = JsonConvert.SerializeObject(templeteModel),
      //  NotifyApplicationId = 1,
      //  OpenId = templeteModel.touser,
      //  TemplateId = templeteModel.template_id,
      //  QueueStatus = QueueStatus.Wait,
      //  QueueStatusCode = ""
      //};
      //_notifyWeChatAppService.QueueSave(entity);

      //var get = _notifyWeChatAppService.QueueGet(entity.Id);

    }

    [TestMethod]
    public void SendTest()
    {
      var accessToken = AccessTokenContainer.GetAccessToken(ConfigurationManager.AppSettings["AppId"]);
      var queue = _notifyWeChatAppService.QueueGet(2);
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
  }
}