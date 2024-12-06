using MountainTrainingApp.Web.ViewModels.AerobicWorkout;

namespace MountainTrainingApp.Services.Data.Interfaces
{
    public interface IAerobicWorkoutService
    {
        //Task<IEnumerable<IndexViewModel>> AllMedicinesAsync();

        Task CreateAerobicWorkoutAsync(AerobicWorkoutAddViewModel model, string trainerId);
    }
}
