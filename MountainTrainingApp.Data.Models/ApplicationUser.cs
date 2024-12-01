namespace MountainTrainingApp.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            AerobicWorkouts=new HashSet<AerobicWorkout>();
            StrengthWorkouts=new HashSet<StrengthWorkout>();
            Climbings=new HashSet<Climbing>();
        }
        public virtual IEnumerable<AerobicWorkout> AerobicWorkouts { get; set; }

        public virtual IEnumerable<StrengthWorkout> StrengthWorkouts { get; set; }

        public virtual IEnumerable<Climbing> Climbings { get; set; }

    }
}
