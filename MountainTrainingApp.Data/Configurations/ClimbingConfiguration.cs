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
               .HasOne(m => m.ClimbingActivity)
               .WithMany(mt => mt.Climbings)
               .HasForeignKey(m => m.ClimbingActivityId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
             .HasOne(m => m.TrainingPeriod)
             .WithMany(mt => mt.Climbings)
             .HasForeignKey(m => m.TrainingPeriodId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
