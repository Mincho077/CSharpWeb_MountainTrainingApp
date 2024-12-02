namespace MountainTrainingApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MountainTrainingApp.Data.Models;
    public class AerobicWorkoutConfiguration : IEntityTypeConfiguration<AerobicWorkout>
    {    
        public void Configure(EntityTypeBuilder<AerobicWorkout> builder)
        {
            builder
                .HasOne(m => m.AerobicActivity)
                .WithMany(mt => mt.AerobicWorkouts)
                .HasForeignKey(m => m.AerobicActivityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(m => m.TrainingPeriod)
                .WithMany(mf => mf.AerobicWorkouts)
                .HasForeignKey(m => m.TrainingPeriodId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
             .HasOne(m => m.Trainer)
             .WithMany(mf => mf.AerobicWorkouts)
             .HasForeignKey(m => m.TrainerId)
             .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
