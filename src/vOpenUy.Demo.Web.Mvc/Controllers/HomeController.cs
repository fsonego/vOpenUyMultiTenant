using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using vOpenUy.Demo.Controllers;

namespace vOpenUy.Demo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
