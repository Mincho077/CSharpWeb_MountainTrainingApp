namespace MountainTrainingApp.Web.ViewModels.Climbing
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.ClimbingConstants;
    using Web.ViewModels.DayOfWeek;
    using Web.ViewModels.ClimbingActivity;
    using Web.ViewModels.TrainingPeriod;

    public class ClimbingAddViewModel
    {
        public ClimbingAddViewModel()
        {
            DaysOfWeek = new HashSet<DayOfWeekViewModel>();
            ClimbingActivities=new HashSet<ClimbingActivityViewModel>();
            TrainingPeriods=new HashSet<TrainingPeriodViewModel>();
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
        [Range(RopesClimbedMinValue,RopesClimbedMaxValue)]
        public int RopesClimbed { get; set; }

        [Required]
        public int ClimbingActivityId { get; set; }

        public IEnumerable<ClimbingActivityViewModel>ClimbingActivities{ get; set; }

        [Required]
        public int TrainingPeriodId { get; set; }

        public IEnumerable<TrainingPeriodViewModel> TrainingPeriods { get; set; }

        [Required]
        public Guid AthletId { get; set; }

        public Guid? TrainerId { get; set; }

    }
}
