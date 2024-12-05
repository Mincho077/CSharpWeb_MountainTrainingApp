namespace MountainTrainingApp.Services.Data.Interfaces
{
    using MountainTrainingApp.Web.ViewModels.DayOfWeek;
    public interface IDayOfWeekService
    {
        Task<IEnumerable<DayOfWeekViewModel>> DaysOfWeekAsync();
    }
}
