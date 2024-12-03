namespace MountainTrainingApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MountainTrainingApp.Data.Models;
    public class TrainingPeriodConfiguration : IEntityTypeConfiguration<TrainingPeriod>
    {
        public void Configure(EntityTypeBuilder<TrainingPeriod> builder)
        {
            builder.HasData(GenerateTrainingPeriod());
        }

        private TrainingPeriod[] GenerateTrainingPeriod()
        {
            ICollection<TrainingPeriod>periods = new HashSet<TrainingPeriod>();

            TrainingPeriod period;

            period=new TrainingPeriod() 
            { 
                Id=1,
                Name= "Transition",
            };

            periods.Add(period);

            period = new TrainingPeriod()
            {
                Id =2,
                Name = "Base"
            };

            periods.Add(period);

            period = new TrainingPeriod()
            {
                Id =3,
                Name = "Specific",
            };

            periods.Add(period);

            return periods.ToArray();
        }
            

    }
}
