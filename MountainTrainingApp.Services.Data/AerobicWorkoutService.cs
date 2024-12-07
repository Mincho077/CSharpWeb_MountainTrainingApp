namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Data.Models;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.AerobicWorkout;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using static Common.EntityValidationConstants.AerobicWorkoutConstants;

    public class AerobicWorkoutService : IAerobicWorkoutService
    {
        private readonly MountainTrainigAppDbContext context;
        public AerobicWorkoutService(MountainTrainigAppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<AerobicWorkoutIndexViewModel>> AllAerobicWorkoutsAsync()
        {
            return await context.AerobicWorkouts
                .OrderByDescending(aw => aw.DateAndTime)
                .Select(aw => new AerobicWorkoutIndexViewModel
                {
                    AerobicActivity=aw.AerobicActivity.Name,
                    DayOfWeek=aw.DayOfWeek.Name,
                    DateAndTime=aw.DateAndTime.ToString(DateFormat),
                    Duration=aw.Duration.ToString(),
                    Distance=aw.Distance.ToString()
                })
                .ToArrayAsync();
        }

        public async Task  CreateAerobicWorkoutAsync(AerobicWorkoutAddViewModel model, string athletId,DateTime date)
        {
            AerobicWorkout workout = new AerobicWorkout()
            {
                Duration = model.Duration,
                ElevationGain = model.ElevationGain,                
                Distance = model.Distance,
                AthletId=Guid.Parse(athletId),
                DateAndTime = date,
                AverageHeartRate = model.AverageHeartRate,
                BurnedCalories=model.BurnedCalories,
                AddedWeight=model.AddedWeight,
                AerobicActivityId=model.AerobicActivityId,
                TrainingPeriodId=model.TrainingPeriodId,
                DayOfWeekId=model.DayOfWeekId,
            };

            await context.AerobicWorkouts.AddAsync(workout);
            await context.SaveChangesAsync();
        }
    }
}
