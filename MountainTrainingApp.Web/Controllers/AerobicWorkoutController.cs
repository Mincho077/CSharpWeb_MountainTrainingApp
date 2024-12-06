namespace MountainTrainingApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Web.ViewModels.AerobicWorkout;
    using Services.Data.Interfaces;

    [Authorize]
    public class AerobicWorkoutController : Controller
    {
        private readonly IAerobicActivityService aerobicActivityService;
        private readonly IAerobicWorkoutService aerobicWorkoutService;
        private readonly ITrainingPeriodService trainingPeriodService;
        private readonly IDayOfWeekService dayOfWeekService;
        public AerobicWorkoutController(IAerobicActivityService aerobicActivityService
            ,IAerobicWorkoutService aerobicWorkoutService
            ,ITrainingPeriodService trainingPeriodService
            ,IDayOfWeekService dayOfWeekService)
        {
            this.aerobicActivityService = aerobicActivityService;
            this.aerobicWorkoutService = aerobicWorkoutService;
            this.trainingPeriodService = trainingPeriodService;
            this.dayOfWeekService = dayOfWeekService;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Add()
        {
            var model=new AerobicWorkoutAddViewModel();
            model.AerobicActivities =
                await aerobicActivityService.AllAerobicActivitiesAsync();

            model.TrainingPeriods=
                await trainingPeriodService.GetTrainingPeriodsAsync();

            model.DaysOfWeek=
                await dayOfWeekService.DaysOfWeekAsync();

            return View(model);
        }

        public IActionResult Mine()
        {
            return View();
        }
    }
}
