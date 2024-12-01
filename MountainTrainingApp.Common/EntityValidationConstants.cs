
namespace MountainTrainingApp.Common
{
    public static class EntityValidationConstants
    {
        public static class AerobicActivityConstants
        {

            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

        }

        public static class TrainingPeriodConstants
        {

            public const int NameMinLength = 5;
            public const int NameMaxLength = 20;

        }

        public static class AerobicWorkoutConstants
        {
            public const string DateFormat = "dd/MM/yyyy HH:mm";


            public const double DurationMinValue = 0.0;
            public const double DurationMaxValue = Double.MaxValue;

            public const int ElevationGainMinValue = 0;
            public const int ElevationGainMaxValue = int.MaxValue;

            public const int AverageHeartRateMinLength = 2;
            public const int AverageHeartRateMaxLength = 3;
        }

        public static class StrengthExerciseConstants
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            public const double AddedWeightMinValue = 0.0;
            public const double AddedWeightMaxValue = Double.MaxValue;

            public const int RepetitionsMinValue = 0;
            public const int RepetitionsMaxValue = int.MaxValue;
        }

        public static class StrengthWorkoutConstats
        {
            public const double DurationMinValue = 0.0;
            public const double DurationMaxValue = Double.MaxValue;
        }

        public static class TrainerConstats
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;
        }

    }
}
