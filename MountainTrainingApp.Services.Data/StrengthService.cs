namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Data.Models;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.Strength;
    using static Common.GeneralApplicationConstats;

    public class StrengthService :IStrengthService
    {
        private readonly MountainTrainigAppDbContext context;

        public StrengthService(MountainTrainigAppDbContext context)
        {
            this.context = context;
        }
        public  async Task<IEnumerable<StrengthIndexViewModel>> AllStrengthWorkoutsAsync()
        {
            return await context.StrengthWorkouts
                .Where(sw => sw.IsDeleted == false)
                .OrderByDescending(sw => sw.DateAndTime)
                .Select(sw => new StrengthIndexViewModel()
                {
                    Id=sw.Id.ToString(),
                    DayOfWeek=sw.DayOfWeek.Name,
                    DateAndTime=sw.DateAndTime.ToString(DateFormat),
                    AddedWeightLegs=sw.AddedWeightLegs.ToString(),
                    AddedWeightUpperBody=sw.AddedWeightUpperBody.ToString(),
                    Duration=sw.Duration.ToString(),
                    StrengthWorkoutType=sw.StrengthWorkoutType.Name,
                    TrainingPeriod=sw.TrainingPeriod.Name,
                    AthetName = sw.Athlet.UserName ?? string.Empty
                })
                .ToArrayAsync();
        }

        public async Task CreateStrengthWorkoutAsync(StrengthAddViewModel model, string athletId, DateTime date)
        {
            StrengthWorkout workout=new StrengthWorkout()
            { 
                StrengthWorkoutTypeId = model.StrengthWorkoutTypeId,
                TrainingPeriodId=model.TrainingPeriodId,
                DayOfWeekId=model.DayOfWeekId,
                AddedWeightLegs=model.AddedWeightLegs,
                Duration=model.Duration,
                Repetitions=model.Repetitions,
                AddedWeightUpperBody=model.AddedWeightUpperBody,
                AthletId=Guid.Parse(athletId),
                DateAndTime=date,
            };

            await context.StrengthWorkouts.AddAsync(workout);
            await context.SaveChangesAsync();
        }
    }
}
