namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.StrengthExerciseConstants;
    public class StrengthExercise
    {
        public StrengthExercise()
        {
            StrengthWorkoutTypes = new HashSet<StrengthWorkoutType>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<StrengthWorkoutType> StrengthWorkoutTypes { get; set; }

    }
}
