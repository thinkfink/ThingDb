using Microsoft.AspNetCore.Mvc;

namespace ThingDb.Web.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
