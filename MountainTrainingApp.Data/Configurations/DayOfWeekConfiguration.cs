namespace MountainTrainingApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MountainTrainingApp.Data.Models;
    using System.Xml.Linq;

    public class DayOfWeekConfiguration : IEntityTypeConfiguration<DayOfWeek>
    {
        public void Configure(EntityTypeBuilder<DayOfWeek> builder)
        {
            builder.HasData(GenerateDayOfWeeks());
        }
        private DayOfWeek[] GenerateDayOfWeeks()
        {
            ICollection<DayOfWeek>dayOfWeeks = new HashSet<DayOfWeek>();

            DayOfWeek day;

            day = new DayOfWeek()
            {
                Id = 1,
                Name = "Monday"
            };

            dayOfWeeks.Add(day);

            day = new DayOfWeek()
            {
                Id= 2,
                Name="Tuesday"
            };

            dayOfWeeks.Add(day);

            day = new DayOfWeek()
            {
                Id=3,
                Name= "Wednesday"
            };

            dayOfWeeks.Add(day);

            day = new DayOfWeek()
            {
                Id=4,
                Name= "Thursday"
            };

            dayOfWeeks.Add(day);

            day = new DayOfWeek()
            {
                Id=5,
                Name="Friday"
            };

            dayOfWeeks.Add(day);

            day = new DayOfWeek()
            {
                Id=6,
                Name = "Saturday"
            };

            dayOfWeeks.Add(day);

            day = new DayOfWeek()
            {
                Id=7,
                Name = "Sunday"
            };

            dayOfWeeks.Add(day);

            return dayOfWeeks.ToArray();
        }
    }
}
