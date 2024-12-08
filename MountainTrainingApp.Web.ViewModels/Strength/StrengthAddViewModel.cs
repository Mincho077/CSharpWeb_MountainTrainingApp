namespace MountainTrainingApp.Web.ViewModels.Strength
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.StrengthWorkoutConstats;
    using MountainTrainingApp.Web.ViewModels.DayOfWeek;
    using MountainTrainingApp.Web.ViewModels.StrengthWorkoutType;
    using MountainTrainingApp.Web.ViewModels.TrainingPeriod;

    public class StrengthAddViewModel
    {
        public StrengthAddViewModel()
        {
            daysOfWeek = new HashSet<DayOfWeekViewModel>();
            StrengthWorkoutTypes=new HashSet<StrengthWorkoutTypeViewModel>();
            TrainingPeriods=new HashSet<TrainingPeriodViewModel>();
        }
        [Required]
        public int DayOfWeekId { get; set; }

        public IEnumerable<DayOfWeekViewModel> daysOfWeek { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        [Range(DurationMinValue, DurationMaxValue)]
        public double Duration { get; set; }

        [Required]
        [Range(RepetitionsMinValue,RepetitionsMaxValue)]
        public int Repetitions { get; set; }

        [Required]
        [Range(AddedWeightMinValue,AddedWeightMaxValue)]
        public double AddedWeightUpperBody { get; set; }

        [Required]
        [Range(AddedWeightMinValue, AddedWeightMaxValue)]
        public double AddedWeightLegs { get; set; }

        [Required]
        public int StrengthWorkoutTypeId { get; set; }

        public IEnumerable<StrengthWorkoutTypeViewModel> StrengthWorkoutTypes { get; set; }

        [Required]
        public int TrainingPeriodId { get; set; }

        public IEnumerable<TrainingPeriodViewModel> TrainingPeriods { get; set; }

        [Required]
        public Guid AthletId { get; set; }

        public Guid? TrainerId { get; set; }

    }
}
