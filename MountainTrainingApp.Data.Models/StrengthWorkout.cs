namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
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
        public virtual TrainingPeriod TrainingPeriod { get; set; } = null!;

        [Required]
        public Guid AthletId { get; set; }

        [Required]
        [ForeignKey(nameof(AthletId))]
        public virtual ApplicationUser Athlet { get; set; } = null!;

        public Guid? TrainerId { get; set; }

        [ForeignKey(nameof(TrainerId))]
        public virtual Trainer? Trainer { get; set; }

        public virtual IEnumerable<StrengthExercise> StrengthExercises { get; set; }
    }
}
