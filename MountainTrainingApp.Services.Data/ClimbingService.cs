using MountainTrainingApp.Services.Data.Interfaces;

namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Data.Models;
    using MountainTrainingApp.Web.ViewModels.Climbing;
    using static Common.GeneralApplicationConstats;
    public class ClimbingService : IClimbingService
    {
        private readonly MountainTrainigAppDbContext context;

        public ClimbingService(MountainTrainigAppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<ClimbingIndexViewModel>> AllClimbingsAsync()
        {
            return await context.Climbings
                .Where(c => c.IsDeleted == false)
                .OrderByDescending(c => c.DateAndTime)
                .AsNoTracking()
                .Select(c => new ClimbingIndexViewModel()
                {
                    Id = c.Id.ToString(),
                    DayOfWeek = c.DayOfWeek.Name,
                    DateAndTime = c.DateAndTime.ToString(DateFormat),
                    Duration = c.Duration.ToString(),
                    RopesClimbed = c.RopesClimbed.ToString(),
                    ClimbingActivity = c.ClimbingActivity.Name,
                    TrainingPeriod = c.TrainingPeriod.Name,
                    AthletName = c.Athlet.UserName ?? string.Empty,

                })
                .ToArrayAsync();

        }

        public async Task CreateClimbingAsync(ClimbingAddViewModel model, string athletId, DateTime date)
        {
            Climbing climbing = new Climbing()
            {
                ClimbingActivityId = model.ClimbingActivityId,
                TrainingPeriodId = model.TrainingPeriodId,
                DayOfWeekId = model.DayOfWeekId,
                Duration = model.Duration,
                AthletId = Guid.Parse(athletId),
                DateAndTime = date,
                RopesClimbed = model.RopesClimbed,

            };

            await context.Climbings.AddAsync(climbing);
            await context.SaveChangesAsync();
        }
    }
}
