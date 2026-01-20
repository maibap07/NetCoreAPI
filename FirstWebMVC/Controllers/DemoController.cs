using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello Nguyễn Hoàng Mai - 2221050423";
            return View();
        }
    }
}
