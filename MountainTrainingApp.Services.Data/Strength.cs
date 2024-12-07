namespace MountainTrainingApp.Services.Data
{
    using MountainTrainingApp.Services.Data.Interfaces;
    using MountainTrainingApp.Web.ViewModels.Strength;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class Strength : IStrength
    {
        public Task<IEnumerable<StrengthIndexViewModel>> AllStrengthWorkoutsAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateStrengthWorkoutAsync(StrengthAddViewModel model, string athletId, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
