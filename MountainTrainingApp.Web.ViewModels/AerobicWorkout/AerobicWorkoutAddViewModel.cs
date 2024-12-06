namespace MountainTrainingApp.Web.ViewModels.AerobicWorkout
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.AerobicWorkoutConstants;
    using MountainTrainingApp.Web.ViewModels.AerobicActivity;
    using MountainTrainingApp.Web.ViewModels.TrainingPeriod;
    using MountainTrainingApp.Web.ViewModels.DayOfWeek;

    public class AerobicWorkoutAddViewModel
    {
        public AerobicWorkoutAddViewModel()
        {
            AerobicActivities = new HashSet<AerobicActivityViewMode>();
            TrainingPeriods = new HashSet<TrainingPeriodViewModel>();
            DaysOfWeek = new HashSet<DayOfWeekViewModel>();
        }
        [Required]
        public int DayOfWeekId { get; set; }

        public IEnumerable<DayOfWeekViewModel> DaysOfWeek { get; set; }

        [Required]
        public string DateAndTime { get; set; } = null!;

        [Required]
        [Range(DurationMinValue,DurationMaxValue)]
        public double Duration { get; set; }

        [Required]
        [Range(ElevationGainMinValue,ElevationGainMaxValue)]
        public int ElevationGain { get; set; }

        [Required]
        [Range(DistanceMinValue, DistanceMaxValue)]
        public int Distance { get; set; }

        [Required]
        [Range(BurnedCaloriesMinValue,BurnedCaloriesMaxValue)]
        public int BurnedCalories { get; set; }

        [Required]
        [MinLength(AverageHeartRateMinLength)]
        [MaxLength(AverageHeartRateMaxLength)]
        public string AverageHeartRate { get; set; } = null!;

        [Required]
        public int AerobicActivityId { get; set; }

        public IEnumerable<AerobicActivityViewMode> AerobicActivities { get; set; }

        [Required]
        public int TrainingPeriodId { get; set; }

        public IEnumerable<TrainingPeriodViewModel> TrainingPeriods { get; set; }

    }
}
