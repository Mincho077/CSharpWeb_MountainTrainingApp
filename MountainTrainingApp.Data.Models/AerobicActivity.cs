namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.AerobicActivityConstants;
    public class AerobicActivity
    {

        public AerobicActivity()
        {
            AerobicWorkouts=new HashSet<AerobicWorkout>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<AerobicWorkout> AerobicWorkouts { get; set; }
    }
}
