﻿
namespace MountainTrainingApp.Common
{
    public static class EntityValidationConstants
    {
        public static class AerobicActivityConstants
        {

            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

        }

        public static class DayOfWeekConstants
        {

            public const int NameMinLength = 6;
            public const int NameMaxLength = 9;

        }

        public static class ClimbingActivityConstants
        {

            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

        }

        public static class ClimbingConstants
        {
            public const double DurationMinValue = 0.0;
            public const double DurationMaxValue = Double.MaxValue;

            public const int RopesClimbedMinValue = 0;
            public const int RopesClimbedMaxValue =int.MaxValue;
        }

        public static class TrainingPeriodConstants
        {

            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

        }

        public static class AerobicWorkoutConstants
        {

            public const double DurationMinValue = 0.0;
            public const double DurationMaxValue = Double.MaxValue;

            public const double DistanceMinValue = 0.0;
            public const double DistanceMaxValue = Double.MaxValue;

            public const double AddedWeightMinValue = 0.0;
            public const double AddedWeightMaxValue = Double.MaxValue;

            public const int ElevationGainMinValue = 0;
            public const int ElevationGainMaxValue = int.MaxValue;

            public const int BurnedCaloriesMinValue = 0;
            public const int BurnedCaloriesMaxValue = int.MaxValue;

            public const int AverageHeartRateMinLength = 2;
            public const int AverageHeartRateMaxLength = 3;

        }

        public static class StrengthWorkoutConstats
        {
            public const double DurationMinValue = 0.0;
            public const double DurationMaxValue = Double.MaxValue;

            public const double AddedWeightMinValue = 0.0;
            public const double AddedWeightMaxValue = Double.MaxValue;

            public const int RepetitionsMinValue = 0;
            public const int RepetitionsMaxValue = int.MaxValue;
           
        }

        public static class StrengthWorkoutTypeConstants
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 20;
        }

        public static class TrainerConstats
        {

            public const int IMFGALicenseNumberMinLength = 10;
            public const int IMFGALicenseNumberMaxLength = 10;
         
        }

    }
}
