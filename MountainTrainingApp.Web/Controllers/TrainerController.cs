namespace MountainTrainingApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    [Authorize]
    public class TrainerController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
