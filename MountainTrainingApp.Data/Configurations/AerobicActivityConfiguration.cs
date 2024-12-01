namespace MountainTrainingApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MountainTrainingApp.Data.Models;
    public class AerobicActivityConfiguration : IEntityTypeConfiguration<AerobicActivity>
    {
        public void Configure(EntityTypeBuilder<AerobicActivity> builder)
        {
            builder.HasData(GenerateAerobicActivities());
        }
        private AerobicActivity[] GenerateAerobicActivities()
        {
            ICollection< AerobicActivity >aerobicActivities=new HashSet< AerobicActivity >();

            AerobicActivity aerobicActivity;

            aerobicActivity = new AerobicActivity()
            {
                Id = 1,
                Name = "Trail running",
            };

            aerobicActivities.Add(aerobicActivity);

            aerobicActivity = new AerobicActivity()
            {
                Id = 2,
                Name = "Hiking",
            };

            aerobicActivity = new AerobicActivity()
            {
                Id = 3,
                Name = "Mountain biking",
            };
            aerobicActivities.Add(aerobicActivity);

            aerobicActivity = new AerobicActivity()
            {
                Id = 4,
                Name = "Road biking",
            };

            aerobicActivities.Add(aerobicActivity);

            aerobicActivity = new AerobicActivity()
            {
                Id = 5,
                Name = "Road running",
            };

            aerobicActivities.Add(aerobicActivity);

            aerobicActivity = new AerobicActivity()
            {
                Id = 6,
                Name = "Cross-country skiing",
            };

            aerobicActivities.Add(aerobicActivity);

            aerobicActivity = new AerobicActivity()
            {
                Id = 7,
                Name = "Swimming",
            };

            aerobicActivities.Add(aerobicActivity);

            return aerobicActivities.ToArray();
        }
    }
}
