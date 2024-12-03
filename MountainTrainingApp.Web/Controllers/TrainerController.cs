using Microsoft.AspNetCore.Mvc;

namespace MountainTrainingApp.Web.Controllers
{
    public class TrainerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
