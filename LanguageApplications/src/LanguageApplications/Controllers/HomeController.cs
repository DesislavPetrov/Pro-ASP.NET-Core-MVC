using Microsoft.AspNetCore.Mvc;

namespace LanguageApplications.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(new string[] { "C#", "Language", "Features" });
        }
    }
}
