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
        public Task CreateAerobicWorkoutAsync(AerobicWorkoutAddViewModel model, string trainerId)
        {
            AerobicWorkout workout= new AerobicWorkout()
            { 
                Duration=model.Duration,
                ElevationGain=model.ElevationGain,
                Distance=model.Distance,
                AverageHeartRate=model.AverageHeartRate,
            };
        }
    }
}
