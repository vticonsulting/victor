using Microsoft.AspNetCore.Mvc;

namespace Victor.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}