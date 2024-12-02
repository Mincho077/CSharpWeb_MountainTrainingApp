namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.StrengthWorkoutConstats;
    public class StrengthWorkout
    {
        public StrengthWorkout()
        {
            Id = Guid.NewGuid();
        }
        [Key]   
        public Guid Id { get; set; }

        [Required]
        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        public double Duration { get; set; }

        [Required]
        [MaxLength(RepetitionsMaxValue)]
        public int Repetitions { get; set; }

        [Required]
        public double AddedWeightUpperBody { get; set; }

        [Required]
        public double AddedWeightLegs { get; set; }

        [Required]
        public int StrengthWorkoutTypeId { get; set; }

        [Required]
        [ForeignKey(nameof(StrengthWorkoutTypeId))]
        public virtual  StrengthWorkoutType StrengthWorkoutType { get; set; } = null!;

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

    }
}
