namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.TrainingPeriod;
    public class TrainingPeriod
    {
        public TrainingPeriod()
        {
            AerobicWorkouts = new HashSet<AerobicWorkout>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<AerobicWorkout> AerobicWorkouts { get; set; }
    }
}
