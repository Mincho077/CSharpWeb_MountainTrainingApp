using MountainTrainingApp.Services.Data.Models.AerobicWorkout;
using MountainTrainingApp.Web.ViewModels.AerobicWorkout;

namespace MountainTrainingApp.Services.Data.Interfaces
{
    public interface IAerobicWorkoutService
    {

        Task<IndexWorkoutsFilteredAndPagedServiceModel> AllAerobicWorkoutsAsync(IndexQueryModel model);

        Task CreateAerobicWorkoutAsync(AerobicWorkoutAddViewModel model, string athletId,DateTime date);

        Task<AerobicWorkoutDetailsViewModel?> GetDetailsByIdAsync(string aerobicWorkoutId);

        Task<IEnumerable<AerobicWorkoutIndexViewModel>> AllByTrainerIdAsync(string trainerId);

        Task<IEnumerable<AerobicWorkoutIndexViewModel>> AllByAthletIdIdAsync(string athletId);
    }
}
