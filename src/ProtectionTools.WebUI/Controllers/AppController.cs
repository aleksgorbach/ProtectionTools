namespace ProtectionTools.WebUI.Controllers {
    using Microsoft.AspNet.Mvc;
    using ViewModels;

    public class AppController : Controller {
        // GET: /app/
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BusViewModel model) {
            return View();
        }

        public IActionResult Test() {
            return Json("test");
        }
    }
}