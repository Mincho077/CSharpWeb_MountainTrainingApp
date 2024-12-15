﻿namespace MountainTrainingApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Globalization;
    using Web.ViewModels.AerobicWorkout;
    using Services.Data.Interfaces;
    using static Common.GeneralApplicationConstats;
    using static Common.NotificationMessagesConstants;
    using Web.Infrastructure.Extensions;
    using MountainTrainingApp.Services.Data.Models.AerobicWorkout;

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

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery]IndexQueryModel queryModel)
        {
            IndexWorkoutsFilteredAndPagedServiceModel model =await aerobicWorkoutService.AllAerobicWorkoutsAsync(queryModel);

            queryModel.AerobicWorkouts= model.AerobicWorkouts;

            queryModel.TotalWorkouts = model.TotalWorkoutsCount;

            queryModel.Types = await 
                aerobicActivityService.AllAerobicActivitiesNamesAsync();

            return View(queryModel);
        }

        [HttpGet]
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

        [HttpPost]
        public async Task<IActionResult> Add(AerobicWorkoutAddViewModel model)
        {
           
            bool aerobicActivitiesExist = await
                aerobicActivityService.AerobicActivityExistByIdAsync(model.AerobicActivityId);

            if (!aerobicActivitiesExist)
            {
                ModelState.AddModelError(nameof(model.AerobicActivityId), "Invalid activity id!");
            }

            bool trainningPeriodExist=await 
                trainingPeriodService.TrainingPeriodExistByIdAsync(model.TrainingPeriodId);

            if (!trainningPeriodExist)
            {
                ModelState.AddModelError(nameof(model.TrainingPeriodId), "Invalid period id!");
            }

            bool dayOdWeekExist=await
                dayOfWeekService.DayOfWeekExistByIdAsync(model.DayOfWeekId);

            if (!dayOdWeekExist)
            {
                ModelState.AddModelError(nameof(model.DayOfWeekId), "Invalid day id!");
            }


            if (!ModelState.IsValid)
            {
                model.AerobicActivities =
                   await aerobicActivityService.AllAerobicActivitiesAsync();

                model.TrainingPeriods =
                    await trainingPeriodService.GetTrainingPeriodsAsync();

                model.DaysOfWeek =
                    await dayOfWeekService.DaysOfWeekAsync();

                return View(model);
            }

            bool isDateValid = DateTime.TryParseExact(model.DateAndTime, DateFormat, CultureInfo.InvariantCulture
               , DateTimeStyles.None, out DateTime dateAndTime);

            if (!isDateValid)
            {

                model.AerobicActivities =
                    await aerobicActivityService.AllAerobicActivitiesAsync();

                model.TrainingPeriods =
                    await trainingPeriodService.GetTrainingPeriodsAsync();

                model.DaysOfWeek =
                    await dayOfWeekService.DaysOfWeekAsync();

                return View(model);
            }

            try
            {
                string athlettId = User.GetUserId();
                await aerobicWorkoutService.CreateAerobicWorkoutAsync(model,athlettId,dateAndTime);

            }
            catch (Exception _)
            {

                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var model=await 
                aerobicWorkoutService.GetDetailsByIdAsync(id);

            if (model==null)
            {
                TempData[ErrorMesage] = "Aerobic workout with the provided id does not exist";

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Mine(string id)
        {
            return View();
        }
    }
}
