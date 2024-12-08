namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.ClimbingActivity;
    public class ClimbingActivityService : IClimbingActivityService
    {
        private readonly MountainTrainigAppDbContext context;
        public ClimbingActivityService(MountainTrainigAppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<ClimbingActivityViewModel>> AllClimbingActivitiesAsync()
        {
            return await context.ClimbingActivities
                .AsNoTracking()
                .Select(ca => new ClimbingActivityViewModel()
                {
                    Id=ca.Id,
                    Name=ca.Name,
                })
                .ToArrayAsync();
        }

        public async Task<bool> ClimbingActivityExistByIdAsync(int id)
        {
            return await context.ClimbingActivities
                .AnyAsync(ca => ca.Id == id);
        }
    }
}
