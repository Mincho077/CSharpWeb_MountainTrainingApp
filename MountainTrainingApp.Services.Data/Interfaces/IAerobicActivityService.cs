using MountainTrainingApp.Web.ViewModels.AerobicActivity;

namespace MountainTrainingApp.Services.Data.Interfaces
{
    public interface IAerobicActivityService
    {
        Task<IEnumerable<AerobicActivityViewMode>> AllAerobicActivitiesAsync();

        Task<bool> AerobicActivityExistByIdAsync(int id);

    }
}
