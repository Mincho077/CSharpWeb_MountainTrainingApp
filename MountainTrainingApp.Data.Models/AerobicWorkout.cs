namespace MountainTrainingApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.AerobicWorkoutConstats;
    public class AerobicWorkout
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }


    }
}
