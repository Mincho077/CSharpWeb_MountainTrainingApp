namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.DayOfWeekConstants;
    public class DayOfWeek
    {

        public DayOfWeek()
        {

            AerobicWorkouts = new HashSet<AerobicWorkout>();
            Climbings = new HashSet<Climbing>();
            StrengthWorkouts = new HashSet<StrengthWorkout>();

        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<AerobicWorkout> AerobicWorkouts { get; set; }

        public virtual IEnumerable<Climbing> Climbings { get; set; }

        public virtual IEnumerable<StrengthWorkout> StrengthWorkouts { get; set; }
    }
}
