using MountainTrainingApp.Web.ViewModels.AerobicWorkout;

namespace MountainTrainingApp.Services.Data.Interfaces
{
    public interface IAerobicWorkoutService
    {
        Task<IEnumerable<AerobicWorkoutIndexViewModel>> AllAerobicWorkoutsAsync();

        Task CreateAerobicWorkoutAsync(AerobicWorkoutAddViewModel model, string trainerId,DateTime date);
    }
}
