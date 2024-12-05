namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.AerobicActivity;

    public class AerobicActivityService : IAerobicActivityService
    {
        private readonly MountainTrainigAppDbContext context;
        public AerobicActivityService(MountainTrainigAppDbContext context)
        {
            this.context = context;
        }
        public async Task<bool> AerobicActivityExistByIdAsync(int id)
        {
            return await context.AerobicActivities
            .AnyAsync(tp => tp.Id == id);
        }

        public async Task<IEnumerable<AerobicActivityViewMode>> AllAerobicActivitiesAsync()
        {
           
            return await context.AerobicActivities
            .AsNoTracking()
            .Select(tp => new AerobicActivityViewMode()
            {
                Id = tp.Id,
                Name = tp.Name,
            })
            .ToArrayAsync();
        }
    }
}
