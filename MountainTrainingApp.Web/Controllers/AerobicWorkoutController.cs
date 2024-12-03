using Microsoft.AspNetCore.Mvc;

namespace MountainTrainingApp.Web.Controllers
{
    public class AerobicWorkoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Mine()
        {
            return View();
        }
    }
}
