﻿namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.AerobicWorkoutConstats;
    public class AerobicWorkout
    {
        public AerobicWorkout()
        {
            Id = new Guid();
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

    }
}
