namespace MountainTrainingApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    public class AerobicWorkoutController : Controller
    {
        public async Task<IActionResult> Index()
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
