using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Abp;
using Abp.Collections;
using Abp.Modules;
using Abp.Dependency;
using Abp.EntityFramework;
using Abp.Reflection;
using Abp.Startup.Application;
using Abp.TestBase;
using Abp.Web;
using Abp.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yufu.Notify.Services;
using Castle.MicroKernel.Registration;

namespace Yufu.Notify.Tests
{
  [TestClass]
  public class UnitTest1 : YufuTestBase
  {
    private IApplicationAppSevice _applicationAppSevice;

    public UnitTest1()
    {

      _applicationAppSevice = LocalIocManager.IocContainer.Resolve<IApplicationAppSevice>();
    }

    [TestMethod]
    public void TestMethod1()
    {
      var application = _applicationAppSevice.Get(2);
    }
  }

}
