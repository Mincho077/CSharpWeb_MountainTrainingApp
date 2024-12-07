namespace MountainTrainingApp.Services.Data.Interfaces
{
    using MountainTrainingApp.Web.ViewModels.StrengthWorkoutType;
    public interface IStrengthWorkoutTypeService
    {
        Task<IEnumerable<StrengthWorkoutTypeViewModel>> AllStrengthWorkoutsAsync();
        Task<bool> StrengthWorkoutExistByIdAsync(int id);
    }
}
