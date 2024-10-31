using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
