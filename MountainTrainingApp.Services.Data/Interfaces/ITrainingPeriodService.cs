namespace MountainTrainingApp.Services.Data.Interfaces
{
    using MountainTrainingApp.Web.ViewModels.TrainingPeriod;
    public interface ITrainingPeriodService
    {

        Task<IEnumerable<TrainingPeriodViewModel>> GetTrainingPeriodsAsync();

        Task<bool> TrainingPeriodExistByIdAsync(int id);

    }
}
