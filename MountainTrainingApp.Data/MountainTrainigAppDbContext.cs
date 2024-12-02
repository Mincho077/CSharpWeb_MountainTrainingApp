namespace MountainTrainingApp.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Reflection;

    public class MountainTrainigAppDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public MountainTrainigAppDbContext(DbContextOptions<MountainTrainigAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<AerobicActivity> AerobicActivities { get; set; } = null!;

        public DbSet<AerobicWorkout> AerobicWorkouts { get; set; } = null!;

        public DbSet<StrengthExercise> StrengthExercises { get; set; } = null!;

        public DbSet<StrengthWorkout> StrengthWorkouts { get; set; } = null!;

        public DbSet<StrengthWorkoutType> StrengthWorkoutTypes { get; set; } = null!;

        public DbSet<ClimbingActivity> ClimbingActivities { get; set; } = null!;

        public DbSet<Climbing> Climbings { get; set; } = null!;

        public DbSet<TrainingPeriod> TrainingPeriods { get; set; } = null!;

        public DbSet<Trainer> Trainers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly assembly = Assembly.GetAssembly(typeof(MountainTrainigAppDbContext)) ??
                Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(builder);

        }
    }
}
