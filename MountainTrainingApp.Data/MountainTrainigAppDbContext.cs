namespace MountainTrainingApp.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;
    public class MountainTrainigAppDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public MountainTrainigAppDbContext(DbContextOptions<MountainTrainigAppDbContext> options)
            : base(options)
        {
        }
    }
}
