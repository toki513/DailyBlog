using Microsoft.AspNetCore.Mvc;

namespace DailyBlog.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
