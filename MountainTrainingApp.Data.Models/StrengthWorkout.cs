namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.AerobicWorkoutConstants;
    public class StrengthWorkout
    {
        public StrengthWorkout()
        {
            StrengthExercises = new HashSet<StrengthExercise>();
        }
        [Key]   
        public int Id { get; set; }

        [Required]
        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        public double Duration { get; set; }

        [Required]
        public int TrainingPeriodId { get; set; }

        [Required]
        [ForeignKey(nameof(TrainingPeriodId))]
        public TrainingPeriod TrainingPeriod { get; set; } = null!;

        public IEnumerable<StrengthExercise> StrengthExercises { get; set; }
    }
}
