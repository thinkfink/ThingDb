using Microsoft.AspNetCore.Mvc;

namespace ThingDb.Web.Controllers
{
    public class RolesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
