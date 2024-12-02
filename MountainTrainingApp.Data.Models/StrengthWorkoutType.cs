namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.StrengthWorkoutTypeConstants;
    public class StrengthWorkoutType
    {
        public StrengthWorkoutType()
        {
            StrengthExercises = new HashSet<StrengthExercise>();
            StrengthWorkouts = new HashSet<StrengthWorkout>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<StrengthWorkout> StrengthWorkouts { get; set; }

        public virtual IEnumerable<StrengthExercise> StrengthExercises { get; set; }

    }
}
