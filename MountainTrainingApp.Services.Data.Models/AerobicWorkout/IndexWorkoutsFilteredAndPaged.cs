using MountainTrainingApp.Web.ViewModels.AerobicWorkout;

namespace MountainTrainingApp.Services.Data.Models.AerobicWorkout
{
    public class IndexWorkoutsFilteredAndPagedServiceModel
    {
        public IndexWorkoutsFilteredAndPagedServiceModel()
        {
            AerobicWorkouts = new HashSet<AerobicWorkoutIndexViewModel>();
        }
        public int TotalWorkoutsCount { get; set; }

        public IEnumerable<AerobicWorkoutIndexViewModel> AerobicWorkouts { get; set; }
    }
}
