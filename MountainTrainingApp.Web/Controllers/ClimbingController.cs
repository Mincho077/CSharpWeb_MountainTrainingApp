namespace MountainTrainingApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.Infrastructure.Extensions;
    using MountainTrainingApp.Web.ViewModels.Climbing;
    using System.Globalization;

    [Authorize]
    public class ClimbingController : Controller
    {
        private readonly IClimbingActivityService climbingActivityService;
        private readonly IClimbingService climbingService;
        private readonly ITrainingPeriodService trainingPeriodService;
        private readonly IDayOfWeekService dayOfWeekService;
       
        public ClimbingController(IClimbingActivityService climbingActivityService
            , IClimbingService climbingService
            , ITrainingPeriodService trainingPeriodService
            , IDayOfWeekService dayOfWeekService)
        {
            this.climbingActivityService = climbingActivityService;
            this.climbingService = climbingService;
            this.trainingPeriodService = trainingPeriodService;
            this.dayOfWeekService = dayOfWeekService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await
                climbingService.AllClimbingsAsync();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ClimbingAddViewModel();

            model.TrainingPeriods= await
                trainingPeriodService.GetTrainingPeriodsAsync();

            model.ClimbingActivities=await
                climbingActivityService.AllClimbingActivitiesAsync();

            model.DaysOfWeek=await
                dayOfWeekService.DaysOfWeekAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ClimbingAddViewModel model)
        {
            bool climbingActivityExist=await 
                climbingActivityService.ClimbingActivityExistByIdAsync(model.ClimbingActivityId);

            if (!climbingActivityExist)
            {
                ModelState.AddModelError(nameof(model.ClimbingActivityId), "Invalid activity id!");
            }

            bool trainningPeriodExist = await
              trainingPeriodService.TrainingPeriodExistByIdAsync(model.TrainingPeriodId);

            if (!trainningPeriodExist)
            {
                ModelState.AddModelError(nameof(model.TrainingPeriodId), "Invalid period id!");
            }

            bool dayOdWeekExist = await
                dayOfWeekService.DayOfWeekExistByIdAsync(model.DayOfWeekId);

            if (!dayOdWeekExist)
            {
                ModelState.AddModelError(nameof(model.DayOfWeekId), "Invalid day id!");
            }

            if (!ModelState.IsValid)
            {

                model.TrainingPeriods = await
                    trainingPeriodService.GetTrainingPeriodsAsync();

                model.ClimbingActivities = await
                    climbingActivityService.AllClimbingActivitiesAsync();

                model.DaysOfWeek = await
                    dayOfWeekService.DaysOfWeekAsync();

                return View(model);
            }

            bool isDateValid = DateTime.TryParseExact(model.DateAndTime, Common.GeneralApplicationConstats.DateFormat, CultureInfo.InvariantCulture
             , DateTimeStyles.None, out DateTime dateAndTime);


            if (!isDateValid)
            {
                model.ClimbingActivities = await
                   climbingActivityService.AllClimbingActivitiesAsync();

                model.TrainingPeriods =
                    await trainingPeriodService.GetTrainingPeriodsAsync();

                model.DaysOfWeek =
                    await dayOfWeekService.DaysOfWeekAsync();

                return View(model);
            }

            try
            {
                string athlettId = User.GetUserId();
                await climbingService.CreateClimbingAsync(model, athlettId, dateAndTime);

            }
            catch (Exception _)
            {

                throw;
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
