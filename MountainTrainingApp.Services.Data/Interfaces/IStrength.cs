namespace MountainTrainingApp.Services.Data.Interfaces
{
    using Web.ViewModels.Strength;
    public interface IStrength
    {
        Task<IEnumerable<StrengthIndexViewModel>> AllStrengthWorkoutsAsync();

        Task CreateStrengthWorkoutAsync(StrengthAddViewModel model, string athletId, DateTime date);
    }
}
