namespace MountainTrainingApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MountainTrainingApp.Data.Models;
    public class StrengthExerciseConfiguration : IEntityTypeConfiguration<StrengthExercise>
    {
        public void Configure(EntityTypeBuilder<StrengthExercise> builder)
        {
            builder.HasData(GenerateStrengthExercises());
        }
        private StrengthExercise[] GenerateStrengthExercises()
        {
            ICollection<StrengthExercise>strengthExercises=new HashSet<StrengthExercise>();

            StrengthExercise exercise;

            exercise = new StrengthExercise()
            {
                Id = 1,
                Name = "Squat"
            };

            strengthExercises.Add(exercise);

            exercise = new StrengthExercise()
            {
                Id = 2,
                Name = "Pull-up"
            };

            strengthExercises.Add(exercise);

            exercise = new StrengthExercise()
            {
                Id = 3,
                Name = "Single leg step up"
            };

            strengthExercises.Add(exercise);

            exercise = new StrengthExercise()
            {
                Id = 4,
                Name = "Push-up"
            };

            strengthExercises.Add(exercise);

            exercise = new StrengthExercise()
            {
                Id = 5,
                Name = "Split squat"
            };

            strengthExercises.Add(exercise);

            exercise = new StrengthExercise()
            {
                Id = 6,
                Name = "Incline pull up"
            };

            strengthExercises.Add(exercise);

            exercise = new StrengthExercise()
            {
                Id = 7,
                Name = "Dip"
            };

            strengthExercises.Add(exercise);

            exercise = new StrengthExercise()
            {
                Id = 8,
                Name = "Squat with heel touch"
            };

            strengthExercises.Add(exercise);

            exercise = new StrengthExercise()
            {
                Id = 9,
                Name = "Hanging legs raise up"
            };

            strengthExercises.Add(exercise);

            return strengthExercises.ToArray();

        }
           
    }
}
