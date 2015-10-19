using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yufu.Notify.Services;

namespace Yufu.Notify.Tests
{
  [TestClass]
  public class ApplicationAppSeviceTests : YufuTestBase
  {
    private IApplicationAppSevice _applicationAppSevice;

    public ApplicationAppSeviceTests()
    {
      _applicationAppSevice = LocalIocManager.IocContainer.Resolve<IApplicationAppSevice>();
    }
  }
}