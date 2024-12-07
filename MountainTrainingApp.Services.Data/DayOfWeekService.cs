namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.DayOfWeek;

    public class DayOfWeekService : IDayOfWeekService
    {
        private readonly MountainTrainigAppDbContext context;

        public DayOfWeekService(MountainTrainigAppDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> DayOfWeekExistByIdAsync(int id)
        {
            return await context.DaysOfWeek
           .AnyAsync(tp => tp.Id == id);
        }

        public async Task<IEnumerable<DayOfWeekViewModel>> DaysOfWeekAsync()
        {
            return await context.DaysOfWeek
            .AsNoTracking()
            .Select(tp => new DayOfWeekViewModel()
            {
                Id = tp.Id,
                Name = tp.Name,
            })
            .ToArrayAsync();
        }
    }
    
}
