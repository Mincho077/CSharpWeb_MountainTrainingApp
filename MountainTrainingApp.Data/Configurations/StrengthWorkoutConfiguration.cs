namespace MountainTrainingApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MountainTrainingApp.Data.Models;
    public class StrengthWorkoutConfiguration : IEntityTypeConfiguration<StrengthWorkout>
    {
        public void Configure(EntityTypeBuilder<StrengthWorkout> builder)
        {
            builder
              .HasOne(sw => sw.StrengthWorkoutType)
              .WithMany(swt => swt.StrengthWorkouts)
              .OnDelete(DeleteBehavior.Restrict);
              
            builder
             .HasOne(sw => sw.TrainingPeriod)
             .WithMany(tp => tp.StrengthWorkouts)
             .HasForeignKey(sw =>sw.TrainingPeriodId)
             .OnDelete(DeleteBehavior.Restrict);

            builder
             .HasOne(sw => sw.Trainer)
             .WithMany(t => t.StrengthWorkouts)
             .HasForeignKey(sw => sw.TrainerId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
