namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.TrainerConstats;

    public class Trainer
    {
        public Trainer()
        {
            Id = Guid.NewGuid();
            AerobicWorkouts = new HashSet<AerobicWorkout>();
            StrengthWorkouts = new HashSet<StrengthWorkout>();
            Climbings= new HashSet<Climbing>();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(IMFGALicenseNumberMaxLength)]
        public string IMFGALicenseNumber { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<AerobicWorkout> AerobicWorkouts { get; set; }

        public virtual ICollection<StrengthWorkout> StrengthWorkouts { get; set; }

        public virtual ICollection<Climbing> Climbings { get; set; }
    }
}
