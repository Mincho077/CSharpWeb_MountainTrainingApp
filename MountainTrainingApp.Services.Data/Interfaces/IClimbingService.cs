namespace MountainTrainingApp.Services.Data.Interfaces
{
    using MountainTrainingApp.Web.ViewModels.Climbing;
    public interface IClimbingService
    {
        Task<IEnumerable<ClimbingIndexViewModel>> AllClimbingsAsync();

        Task CreateClimbingAsync(ClimbingAddViewModel model, string athletId, DateTime date);
    }
}
