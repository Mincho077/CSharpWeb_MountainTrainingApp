using MountainTrainingApp.Web.ViewModels.Trainer;

namespace MountainTrainingApp.Services.Data.Interfaces
{
    public interface ITrainerService
    {
        Task CreateTrainerAsync(string userId, RegisterTrainerViewModel model);

        Task<string> GetTrainerIdByUserId(string userId);
        Task<bool> TainerExistByUserIdAsync(string userId);

        Task<bool> TarnerExisByIMFGALicenseNumberIdAsync(string IMFGALicenseNumber);

        Task<bool> HasStrengthWorkoutsByUserIdAsync(string userId);

        Task<bool> HasAerobicWorkoutsByUserIdAsync(string userId);

        Task<bool> HasClimbingsByUserIdAsync(string userId);
    }
}
