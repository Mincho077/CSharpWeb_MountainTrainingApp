namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.TrainingPeriod;

    public class TrainingPeriodService : ITrainingPeriodService
    {
        private readonly MountainTrainigAppDbContext context;
        public TrainingPeriodService(MountainTrainigAppDbContext context)
        {
           this.context = context;
        }
        public async Task<IEnumerable<TrainingPeriodViewModel>> GetTrainingPeriodsAsync()
        {
            return await context.TrainingPeriods
               .AsNoTracking()
               .AsNoTracking()
               .Select(tp => new TrainingPeriodViewModel()
               {
                   Id = tp.Id,
                   Name = tp.Name,
               })
               .ToArrayAsync();
        }

        public async Task<bool> TrainingPeriodExistByIdAsync(int id)
        {
            return await context.TrainingPeriods
                .AnyAsync(tp => tp.Id == id);
        }
    }
}
