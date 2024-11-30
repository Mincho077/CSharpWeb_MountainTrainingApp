
namespace MountainTrainingApp.Common
{
    public static class EntityValidationConstants
    {
        public static class AerobicActivityConstants
        {

            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

        }

        public static class TrainingPeriod
        {

            public const int NameMinLength = 5;
            public const int NameMaxLength = 20;

        }

        public static class AerobicWorkoutConstats
        {
            public const string DateFormat = "dd/MM/yyyy HH:mm";


            public const double DurationMinValue = 0.0;
            public const double DurationMaxValue = Double.MaxValue;

            public const int ElevationGainMinValue = 0;
            public const int ElevationGainMaxValue = int.MaxValue;

            public const int AverageHeartRateMinLength = 2;
            public const int AverageHeartRateMaxLength = 3;
        }

    }
}
