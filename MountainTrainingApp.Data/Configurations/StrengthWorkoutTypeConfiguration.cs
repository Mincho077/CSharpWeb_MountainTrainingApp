namespace MountainTrainingApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MountainTrainingApp.Data.Models;
    public class StrengthWorkoutTypeConfiguration : IEntityTypeConfiguration<StrengthWorkoutType>
    {
        public void Configure(EntityTypeBuilder<StrengthWorkoutType> builder)
        {         

           builder.HasData(GenerateStrengthWorkoutTypes());
        }

        private StrengthWorkoutType[] GenerateStrengthWorkoutTypes()
        {
            ICollection<StrengthWorkoutType> types=new HashSet<StrengthWorkoutType>();

            StrengthWorkoutType type;
            type=new StrengthWorkoutType() 
            {
               Id = 1,
               Name= "General strength"
            };

            types.Add(type);

            type = new StrengthWorkoutType()
            {
                Id = 2,
                Name = "Max strength"
            };

            types.Add(type);

            type = new StrengthWorkoutType()
            {
                Id = 3,
                Name = "Muscle endurance"
            };

            types.Add(type);

            return types.ToArray();
        }
    }
}
