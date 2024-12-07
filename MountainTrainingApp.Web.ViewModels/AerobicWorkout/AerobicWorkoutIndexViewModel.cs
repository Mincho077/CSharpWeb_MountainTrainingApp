using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MountainTrainingApp.Web.ViewModels.AerobicWorkout
{
    public class AerobicWorkoutIndexViewModel
    {
        public string Id { get; set; } = null!;

        public  string DayOfWeek { get; set; } = null!;

        public string DateAndTime { get; set; } = null!;

        public string Duration { get; set; } = null!;

        public string Distance { get; set; } = null!;

        public string BurnedCalories { get; set; } = null!;

        public string AddedWeight { get; set; } = null!;

        public string ElevationGain { get; set; } = null!;

        public string AverageHeartRate { get; set; } = null!;

        public string AerobicActivity { get; set; } = null!;

        public string TrainingPeriod { get; set; } = null!;


    }
}
