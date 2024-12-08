namespace MountainTrainingApp.Web.ViewModels.Climbing
{
    public class ClimbingIndexViewModel
    {
        public string Id { get; set; } = null!;

        public string DayOfWeek { get; set; } = null!;

        public string DateAndTime { get; set; }=null!;

        public string Duration { get; set; } = null!;

        public string RopesClimbed { get; set; } = null!;

        public string ClimbingActivity { get; set; } = null!;

        public string TrainingPeriod { get; set; } = null!;

        public string AthletName { get; set; } = null!;

        public string? TrainerName { get; set; }
    }
}
