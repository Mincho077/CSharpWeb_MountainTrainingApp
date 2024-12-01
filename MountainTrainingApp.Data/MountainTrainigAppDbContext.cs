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

        public DbSet<AerobicActivity> AerobicActivities { get; set; }

        public DbSet<AerobicWorkout> AerobicWorkouts { get; set; }

        public DbSet<StrengthExercise> StrengthExercises { get; set; }

        public DbSet<StrengthWorkout> StrengthWorkouts { get; set; }

        public DbSet<ClimbingActivity> ClimbingActivities { get; set; }

        public DbSet<Climbing> Climbings { get; set; }

        public DbSet<TrainingPeriod> TrainingPeriods { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly assembly = Assembly.GetAssembly(typeof(MountainTrainigAppDbContext)) ??
                Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(builder);

        }
    }
}
