namespace MountainTrainingApp.Web.ViewModels.AerobicWorkout
{
    using System.ComponentModel.DataAnnotations;
    using static Common.GeneralApplicationConstats;
    using Enums;
    public class IndexQueryModel
    {
        public IndexQueryModel()
        {
            CurrentPage = DefaultPage;
            WorkoutsPerPage = EntitiesPerPage;
            Types=new HashSet<string>();
            AerobicWorkouts=new HashSet<AerobicWorkoutIndexViewModel>();
        }
        public string? Type { get; set; }

        [Display(Name ="Search by word")]
        public string? SearchString { get; set; }

        [Display(Name = "Sort Workouts By")]
        public WorkoutSorting WorkoutSorting { get; set; }

        public int CurrentPage { get; set; }

        public int TotalWorkouts { get; set; }

        public int WorkoutsPerPage { get; set; }

        public IEnumerable<string> Types { get; set; }

        public IEnumerable<AerobicWorkoutIndexViewModel> AerobicWorkouts { get; set; }

    }
}
