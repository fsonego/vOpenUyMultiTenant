using Microsoft.AspNetCore.Antiforgery;
using vOpenUy.Demo.Controllers;

namespace vOpenUy.Demo.Web.Host.Controllers
{
    public class AntiForgeryController : DemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}