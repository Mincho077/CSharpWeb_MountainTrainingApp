namespace MountainTrainingApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MountainTrainingApp.Data.Models;
    public class ClimbingActivityConfiguration : IEntityTypeConfiguration<ClimbingActivity>
    {      
        public void Configure(EntityTypeBuilder<ClimbingActivity> builder)
        {
            builder.HasData(GenerateClimbingActivities());
        }

        private ClimbingActivity[] GenerateClimbingActivities()
        {
            ICollection<ClimbingActivity>climbings=new HashSet<ClimbingActivity>();

            ClimbingActivity climbing;

            climbing=new ClimbingActivity() 
            { 
                Id = 1,
                Name="Sport rock climbing",
            };

            climbings.Add(climbing);

            climbing = new ClimbingActivity()
            {
                Id = 2,
                Name = "Trad rock climbing",
            };

            climbings.Add(climbing);

            climbing = new ClimbingActivity()
            {
                Id = 3,
                Name = "Ice climbing",
            };

            climbings.Add(climbing);

            climbing = new ClimbingActivity()
            {
                Id = 4,
                Name = "Mixed climbing",
            };

            climbings.Add(climbing);

            climbing = new ClimbingActivity()
            {
                Id = 5,
                Name = "Alpine climbing",
            };

            climbings.Add(climbing);

            return climbings.ToArray();
        }
    }
}
