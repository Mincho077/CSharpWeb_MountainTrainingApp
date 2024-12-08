namespace MountainTrainingApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Globalization;
    using MountainTrainingApp.Services.Data.Interfaces;
    using Web.Infrastructure.Extensions;
    using Web.ViewModels.Strength;
    using Microsoft.AspNetCore.Authorization;

    [Authorize]
    public class StrengthController : Controller
    {
        private readonly IStrengthService strengthService;
        private readonly IStrengthWorkoutTypeService strengthWorkoutTypeService;
        private readonly IDayOfWeekService dayOfWeekService;
        private readonly ITrainingPeriodService trainingPeriodService;

        public StrengthController(IStrengthService strengthService 
            ,IStrengthWorkoutTypeService strengthWorkoutTypeService
            ,IDayOfWeekService dayOfWeekService
            ,ITrainingPeriodService trainingPeriodService)
        {
            this.strengthService = strengthService;
            this.strengthWorkoutTypeService= strengthWorkoutTypeService;
            this.dayOfWeekService = dayOfWeekService;
            this.trainingPeriodService = trainingPeriodService;
        }
        public async Task<IActionResult> Index()
        {
            var model= await strengthService.AllStrengthWorkoutsAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new StrengthAddViewModel();
            model.TrainingPeriods = 
                await trainingPeriodService.GetTrainingPeriodsAsync();
            model.DaysOfWeek=
                await dayOfWeekService.DaysOfWeekAsync();
            model.StrengthWorkoutTypes=
                await strengthWorkoutTypeService.AllStrengthWorkoutsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(StrengthAddViewModel model)
        {
            bool strengthTypeExist = await
              strengthWorkoutTypeService.StrengthWorkoutExistByIdAsync(model.StrengthWorkoutTypeId);

            if (!strengthTypeExist)
            {
                ModelState.AddModelError(nameof(model.StrengthWorkoutTypeId), "Invalid type id!");
            }

            bool trainningPeriodExist = await
                trainingPeriodService.TrainingPeriodExistByIdAsync(model.TrainingPeriodId);

            if (!trainningPeriodExist)
            {
                ModelState.AddModelError(nameof(model.TrainingPeriodId), "Invalid period id!");
            }

            bool dayOdWeekExist = await
                dayOfWeekService.DayOfWeekExistByIdAsync(model.DayOfWeekId);

            if (!trainningPeriodExist)
            {
                ModelState.AddModelError(nameof(model.DayOfWeekId), "Invalid day id!");
            }


            if (!ModelState.IsValid)
            {
                model.StrengthWorkoutTypes =
                   await strengthWorkoutTypeService.AllStrengthWorkoutsAsync();

                model.TrainingPeriods =
                    await trainingPeriodService.GetTrainingPeriodsAsync();

                model.DaysOfWeek =
                    await dayOfWeekService.DaysOfWeekAsync();

                return View(model);
            }

            bool isDateValid = DateTime.TryParseExact(model.DateAndTime, Common.GeneralApplicationConstats.DateFormat
                , CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateAndTime);

            if (!isDateValid)
            {

                model.StrengthWorkoutTypes =
                    await strengthWorkoutTypeService.AllStrengthWorkoutsAsync();

                model.TrainingPeriods =
                    await trainingPeriodService.GetTrainingPeriodsAsync();

                model.DaysOfWeek =
                    await dayOfWeekService.DaysOfWeekAsync();
                return View(model);
            }

            try
            {
                string athlettId = User.GetUserId();
                await strengthService.CreateStrengthWorkoutAsync(model, athlettId, dateAndTime);

            }
            catch (Exception _)
            {

                throw;
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
