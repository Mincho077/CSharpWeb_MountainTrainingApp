namespace MountainTrainingApp.Services.Data.Interfaces
{
    using Web.ViewModels.Strength;
    public interface IStrengthService
    {
        Task<IEnumerable<StrengthIndexViewModel>> AllStrengthWorkoutsAsync();

        Task CreateStrengthWorkoutAsync(StrengthAddViewModel model, string athletId, DateTime date);
    }
}
