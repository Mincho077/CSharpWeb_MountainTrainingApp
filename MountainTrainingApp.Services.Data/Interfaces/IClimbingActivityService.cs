namespace MountainTrainingApp.Services.Data.Interfaces
{
    using MountainTrainingApp.Web.ViewModels.ClimbingActivity;
    public interface IClimbingActivityService
    {
        Task<IEnumerable<ClimbingActivityViewModel>> AllClimbingActivitiesAsync();
        Task<bool> ClimbingActivityExistByIdAsync(int id);
    }
}
