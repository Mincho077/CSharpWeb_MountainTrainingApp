namespace MountainTrainingApp.Web.ViewModels.AerobicWorkout
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.AerobicWorkoutConstants;
    using MountainTrainingApp.Web.ViewModels.AerobicActivity;
    using MountainTrainingApp.Web.ViewModels.TrainingPeriod;

    public class AerobicWorkoutAddViewModel
    {
        public AerobicWorkoutAddViewModel()
        {
            AerobicActivities = new HashSet<AerobicActivityViewMode>();
            TrainingPeriods = new HashSet<TrainingPeriodViewModel>();
        }
        [Required]
        public string DayOfWeek { get; set; } = null!;

        [Required]
        public string DateAndTime { get; set; } = null!;

        [Required]
        [Range(DurationMinValue,DurationMaxValue)]
        public double Duration { get; set; }

        [Required]
        [Range(ElevationGainMinValue,ElevationGainMaxValue)]
        public int ElevationGain { get; set; }

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

        [Required]
        public bool IsDeleted { get; set; }
    }
}
