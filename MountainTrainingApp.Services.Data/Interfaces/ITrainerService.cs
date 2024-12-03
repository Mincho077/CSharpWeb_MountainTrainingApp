namespace MountainTrainingApp.Services.Data.Interfaces
{
    public interface ITrainerService
    {
        Task<bool> TainerExistByUserIdAsync(string userId);

        Task<bool> TarnerExistNameIdAsync(string phoneNumber);
    }
}
