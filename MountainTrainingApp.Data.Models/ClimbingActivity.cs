namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.ClimbingActivityConstants;
    public class ClimbingActivity
    {
        public ClimbingActivity()
        {
            Climbings=new HashSet<Climbing>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<Climbing> Climbings { get; set; }

    }
}
