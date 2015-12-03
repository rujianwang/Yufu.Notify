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
using Yufu.Notify.Shared.WeChatTemplateData.Dto;
using Yufu.Notify.Tests.Dto;

namespace Yufu.Notify.Tests
{
  [TestClass]
  public class NotifyWeChatAppServiceTests : YufuTestBase
  {
    private IWebApiAppService _webApiAppService;

    public NotifyWeChatAppServiceTests()
    {
      _webApiAppService = LocalIocManager.IocContainer.Resolve<IWebApiAppService>();
    }


    [TestMethod]
    public void TestAdd()
    {

      var templeteData = CreateCommonTemplateData("新的竞价提醒", "您的托运有新的竞价",
        "更详细信息，请到恒物流官方网站（http://www.heng56.com）查看！");
      var templeteModel = CreateTempleteModel("oXovSsiYSiurBI7hQ4E8ynjaBorM", templeteData,
        "http://m.kai56.com/home/index");
      var dto = CreateNotifyWeChatQueueDto(templeteModel);

      _webApiAppService.PostCreateNotifyWeChatQueue(dto);

    }

    [TestMethod]
    public void SendTest()
    {

    }

    public static CommonTemplateData CreateCommonTemplateData(string first, string keyword2,
      string remark, string keyword1 = "恒物流官方")
    {
      return new CommonTemplateData
      {
        first = new TemplateDataItem(first),
        keyword1 = new TemplateDataItem(keyword1),
        keyword2 = new TemplateDataItem(keyword2),
        remark = new TemplateDataItem(remark)
      };
    }

    public static TempleteModel CreateTempleteModel(string touser, object data, string url = "http://m.kai56.com",
      string templateid = "n_82Xy8snQa4BlmZi8qDVGsGbE7WSoanufi0IPu3PCA", string topcolor = "#FF0000")
    {
#if DEBUG
      templateid = "ZraAegsmP1Y9tWWBH1FTTajyt18tNgYwsl4MpAwQoPI";
#endif
      return new TempleteModel
      {
        data = data,
        template_id = templateid,
        topcolor = topcolor,
        touser = touser,
        url = url
      };
    }

    public static NotifyWeChatQueueDto CreateNotifyWeChatQueueDto(TempleteModel templeteModel, int notifyApplicationId = 1)
    {
      var entity = new NotifyWeChatQueueDto
      {
        NotifyApplicationId = 1,
        OpenId = templeteModel.touser,
        TemplateId = templeteModel.template_id,
        Body = JsonConvert.SerializeObject(templeteModel)
      };
      return entity;
    }
  }
}