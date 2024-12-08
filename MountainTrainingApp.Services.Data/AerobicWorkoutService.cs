namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Data.Models;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.AerobicWorkout;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using static Common.GeneralApplicationConstats;

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
                .Where(aw=>aw.IsDeleted==false)
                .OrderByDescending(aw => aw.DateAndTime)
                .Select(aw => new AerobicWorkoutIndexViewModel
                {
                    Id=aw.Id.ToString(),
                    AerobicActivity=aw.AerobicActivity.Name,
                    DayOfWeek=aw.DayOfWeek.Name,
                    DateAndTime=aw.DateAndTime.ToString(DateFormat),
                    Duration=aw.Duration.ToString(),
                    Distance=aw.Distance.ToString(),
                    AthetName=aw.Athlet.UserName??string.Empty
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
