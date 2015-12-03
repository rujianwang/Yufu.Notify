using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yufu.Notify.Services.IServices;
using Yufu.Notify.Shared.App.Dto;

namespace Yufu.Notify.Tests
{
  [TestClass]
  public class NotifyAppCanAppServiceTests : YufuTestBase
  {
    private IAppAppService _appAppService;
    private IWebApiAppService _webApiAppService;

    public NotifyAppCanAppServiceTests()
    {
      _appAppService = LocalIocManager.IocContainer.Resolve<IAppAppService>();
      _webApiAppService = LocalIocManager.IocContainer.Resolve<IWebApiAppService>();
    }

    [TestMethod]
    public void TestPushSoftToken()
    {
      _webApiAppService.PostCreateNotifyAppQueue(new NotifyAppQueueDto
      {
        NotifyApplicationId = 1,
        AppId = "11428077",//恒物流发货版
        Body = "{}",
        PushType = PushType.SoftToken,
        List = "c35c279fb323e889bdb1eeb0ed67a8e6",
        Platforms = "1",//1：android;0：ios
        Title = "推送测试"
      });

    }

  }
}