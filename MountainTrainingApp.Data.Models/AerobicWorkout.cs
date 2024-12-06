namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.AerobicWorkoutConstants;
    public class AerobicWorkout
    {
        public AerobicWorkout()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int DayOfWeekId { get; set; }

        [Required]
        [ForeignKey(nameof(DayOfWeekId))]
        public virtual DayOfWeek DayOfWeek { get; set; } = null!;

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        public double Duration { get; set; }

        [Required]
        public double Distance { get; set; }

        [Required]
        public double BurnedCalories { get; set; }

        [Required]
        public int ElevationGain { get; set; }

        [Required]
        [MaxLength(AverageHeartRateMaxLength)]
        public string AverageHeartRate { get; set; } = null!;

        [Required]
        public int AerobicActivityId { get; set; }

        [Required]
        [ForeignKey(nameof(AerobicActivityId))]
        public virtual AerobicActivity AerobicActivity { get; set; } = null!;

        [Required]
        public int TrainingPeriodId { get; set; }

        [Required]
        [ForeignKey(nameof(TrainingPeriodId))]
        public virtual TrainingPeriod TrainingPeriod { get; set; }= null!;

        [Required]
        public Guid AthletId { get; set; }

        [Required]
        [ForeignKey(nameof(AthletId))]
        public virtual ApplicationUser Athlet { get; set; }=null!;

        public Guid? TrainerId { get; set; }

        [ForeignKey(nameof(TrainerId))]
        public virtual Trainer? Trainer { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

    }
}
