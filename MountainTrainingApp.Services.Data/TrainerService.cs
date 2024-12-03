namespace MountainTrainingApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using MountainTrainingApp.Data;
    using MountainTrainingApp.Data.Models;
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.Trainer;

    public class TrainerService : ITrainerService
    {
        private readonly MountainTrainigAppDbContext context;
        public TrainerService(MountainTrainigAppDbContext context)
        {
            this.context = context;
        }

        public async Task CreateTrainerAsync(string userId, RegisterTrainerViewModel model)
        {
            Trainer trainer=new Trainer() 
            { 
                Id=Guid.NewGuid(),
                Name=model.Name,
            };

            await context.Trainers.AddAsync(trainer);
            await context.SaveChangesAsync();
        }
        public async Task<bool> TainerExistByUserIdAsync(string userId)
        {
            return await context.Trainers
                .AnyAsync(t => t.UserId.ToString() == userId);
        }

        public async Task<bool> TarnerExistNameIdAsync(string name)
        {
            return await context.Trainers
                .AnyAsync(t=>t.Name==name);
        }
    }
}
