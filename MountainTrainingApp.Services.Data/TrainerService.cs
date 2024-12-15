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
                IMFGALicenseNumber=model.IMFGALicenseNumber,
            };

            await context.Trainers.AddAsync(trainer);
            await context.SaveChangesAsync();
        }

        public async Task<string> GetTrainerIdByUserId(string userId)
        {
           Trainer? trainer= await context.Trainers
                .FindAsync(userId);
            if (trainer==null)
            {
                return "Invalid Id";
            }

            return trainer.Id.ToString();
        }

        public async Task<bool> HasAerobicWorkoutsByUserIdAsync(string userId)
        {
            ApplicationUser? user = await context.Users
               .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                return false;
            }
            return user.AerobicWorkouts.Any();
        }

        public async Task<bool> HasClimbingsByUserIdAsync(string userId)
        {
            ApplicationUser? user = await context.Users
              .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                return false;
            }
            return user.Climbings.Any();
        }

        public async Task<bool> HasStrengthWorkoutsByUserIdAsync(string userId)
        {
            ApplicationUser? user = await context.Users
              .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user == null)
            {
                return false;
            }
            return user.StrengthWorkouts.Any();
        }

        public async Task<bool> TainerExistByUserIdAsync(string userId)
        {
            return await context.Trainers
                .AnyAsync(t => t.UserId.ToString() == userId);
        }

        public async Task<bool> TarnerExisByIMFGALicenseNumberIdAsync(string IMFGALicenseNumber)
        {
            return await context.Trainers
                .AnyAsync(t=>t.IMFGALicenseNumber == IMFGALicenseNumber);
        }
    }
}
