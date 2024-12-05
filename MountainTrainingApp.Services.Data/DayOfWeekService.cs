namespace MountainTrainingApp.Services.Data
{
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.DayOfWeek;
    public class DayOfWeekService : IDayOfWeekService
    {
        public Task<IEnumerable<DayOfWeekViewModel>> DaysOfWeekAsync()
        {
            throw new NotImplementedException();
        }
    }
}
