namespace MountainTrainingApp.Services.Data.Interfaces
{
    using MountainTrainingApp.Web.ViewModels.AerobicActivity;
    public interface IAerobicActivityService
    {
        Task<IEnumerable<AerobicActivityViewMode>> AllAerobicActivitiesAsync();
        Task<bool> AerobicActivityExistByIdAsync(int id);
       
    }
}
