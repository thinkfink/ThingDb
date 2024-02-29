using Microsoft.AspNetCore.Mvc;

namespace ThingDb.Web.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
