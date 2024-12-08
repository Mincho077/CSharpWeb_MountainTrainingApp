namespace MountainTrainingApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MountainTrainingApp.Services.Data.Interfaces;
    using Web.ViewModels.Strength;
    using Web.ViewModels.StrengthWorkoutType;
    public class ClimbingComtroller : Controller
    {
        
       
        public ClimbingComtroller()
        {
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}
