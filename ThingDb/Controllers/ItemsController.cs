using Microsoft.AspNetCore.Mvc;

namespace ThingDb.Web.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
