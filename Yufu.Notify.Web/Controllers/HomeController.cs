using System.Web.Mvc;
using Yufu.Notify.Services;

namespace Yufu.Notify.Web.Controllers
{
  public class HomeController : NotifyControllerBase
  {
    private IApplicationAppSevice _applicationAppSevice;

    public HomeController(IApplicationAppSevice applicationAppSevice)
    {
      _applicationAppSevice = applicationAppSevice;
    }


    public ActionResult Index()
    {
      var entity = _applicationAppSevice.Get(1);
      return View();
    }
  }
}