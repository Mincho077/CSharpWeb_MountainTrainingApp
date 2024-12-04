using MountainTrainingApp.Web.ViewModels.Trainer;

namespace MountainTrainingApp.Services.Data.Interfaces
{
    public interface ITrainerService
    {
        Task CreateTrainerAsync(string userId, RegisterTrainerViewModel model);

        Task<bool> TainerExistByUserIdAsync(string userId);

        Task<bool> TarnerExistNameIdAsync(string phoneNumber);
        Task<bool> HasStrengthWorkoutsByUserIdAsync(string userId);
        Task<bool> HasAerobicWorkoutsByUserIdAsync(string userId);
        Task<bool> HasClimbingsByUserIdAsync(string userId);
    }
}
