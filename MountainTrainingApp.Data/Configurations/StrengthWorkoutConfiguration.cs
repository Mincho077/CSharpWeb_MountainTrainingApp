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
              .HasOne(m => m.StrengthWorkoutType)
              .WithMany(mt => mt.StrengthWorkouts)
              .OnDelete(DeleteBehavior.Restrict);
              
            builder
             .HasOne(m => m.TrainingPeriod)
             .WithMany(mt => mt.StrengthWorkouts)
             .HasForeignKey(m => m.TrainingPeriodId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
