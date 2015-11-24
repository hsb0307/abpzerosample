using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Husb.Community.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CommunityControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}