namespace MountainTrainingApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MountainTrainingApp.Data.Models;
    public class ClimbingConfiguration : IEntityTypeConfiguration<Climbing>
    {
        public void Configure(EntityTypeBuilder<Climbing> builder)
        {
            builder
              .HasOne(c => c.ClimbingActivity)
              .WithMany(ca => ca.Climbings)
              .HasForeignKey(c => c.ClimbingActivityId)
              .OnDelete(DeleteBehavior.Restrict);

            builder
             .HasOne(c => c.TrainingPeriod)
             .WithMany(tp => tp.Climbings)
             .HasForeignKey(c => c.TrainingPeriodId)
             .OnDelete(DeleteBehavior.Restrict);

            builder
             .HasOne(c => c.Trainer)
             .WithMany(tp => tp.Climbings)
             .HasForeignKey(c => c.TrainerId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
