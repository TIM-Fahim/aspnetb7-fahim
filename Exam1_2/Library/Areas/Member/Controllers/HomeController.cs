using Microsoft.AspNetCore.Mvc;
//Exam1_2.Library.Areas.Admin.Controllers
namespace Exam1_2.Library.Areas.Member.Controllers
{
    [Area("Member")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
