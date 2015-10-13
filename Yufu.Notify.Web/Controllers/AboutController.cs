using System.Web.Mvc;

namespace Yufu.Notify.Web.Controllers
{
    public class AboutController : NotifyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}