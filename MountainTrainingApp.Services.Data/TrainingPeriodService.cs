namespace MountainTrainingApp.Services.Data
{
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.TrainingPeriod;
    public class TrainingPeriodService : ITrainingPeriodService
    {
        public Task<IEnumerable<TrainingPeriodViewModel>> GetTrainingPeriodsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> TrainingPeriodsExistByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
