namespace MountainTrainingApp.Services.Data
{
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Data.Models;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.AerobicWorkout;
    using System.Threading.Tasks;

    public class AerobicWorkoutService : IAerobicWorkoutService
    {
        private readonly MountainTrainigAppDbContext context;
        public AerobicWorkoutService(MountainTrainigAppDbContext context)
        {
            this.context = context;
        }
        public async Task  CreateAerobicWorkoutAsync(AerobicWorkoutAddViewModel model, string trainerId)
        {
            AerobicWorkout workout = new AerobicWorkout()
            {
                Duration = model.Duration,
                ElevationGain = model.ElevationGain,
                Distance = model.Distance,
                TrainerId = Guid.Parse(trainerId),
                AverageHeartRate = model.AverageHeartRate,
                BurnedCalories=model.BurnedCalories,
            };

            await context.AerobicWorkouts.AddAsync(workout);
            await context.SaveChangesAsync();
        }
    }
}
