namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.StrengthExerciseConstants;
    public class StrengthExercise
    {
        public StrengthExercise()
        {
            StrengthWorkouts=new HashSet<StrengthWorkout>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public double AddedWeight { get; set; }

        [Required]
        public int Repetitions { get; set; }

        public IEnumerable<StrengthWorkout> StrengthWorkouts { get; set; }

    }
}
