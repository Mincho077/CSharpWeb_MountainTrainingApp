namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.StrengthWorkoutTypeConstants;
    public class StrengthWorkoutType
    {
        public StrengthWorkoutType()
        {
            StrengthWorkouts=new HashSet<StrengthWorkout>(); 
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<StrengthWorkout> StrengthWorkouts { get; set; }
        

    }
}
