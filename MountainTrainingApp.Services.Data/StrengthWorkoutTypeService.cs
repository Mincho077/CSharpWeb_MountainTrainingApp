namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.StrengthWorkoutType;
    public class StrengthWorkoutTypeService : IStrengthWorkoutTypeService
    {
        private readonly MountainTrainigAppDbContext context;
        public StrengthWorkoutTypeService(MountainTrainigAppDbContext context)
        {
                this.context = context;
        }
        public async Task<IEnumerable<StrengthWorkoutTypeViewModel>> AllStrengthWorkoutsAsync()
        {
            return await context.StrengthWorkoutTypes
                .AsNoTracking()
                .Select(swt => new StrengthWorkoutTypeViewModel()
                {
                     Id = swt.Id,
                     Name = swt.Name,
                })
                .ToArrayAsync();
        }

        public async Task<bool> StrengthWorkoutExistByIdAsync(int id)
        {
            return await context.StrengthWorkoutTypes
              .AnyAsync(swt => swt.Id == id);
        }
    }
}
