using MountainTrainingApp.Web.ViewModels.Trainer;

namespace MountainTrainingApp.Services.Data.Interfaces
{
    public interface ITrainerService
    {
        Task CreateTrainerAsync(string userId, RegisterTrainerViewModel model);
        Task<bool> TainerExistByUserIdAsync(string userId);

        Task<bool> TarnerExistNameIdAsync(string phoneNumber);
    }
}
