namespace MountainTrainingApp.Web.ViewModels.Trainer
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.TrainerConstats;
    public class RegisterTrainerViewModel
    {
        [Required]
        [MinLength(IMFGALicenseNumberMinLength)]
        [MaxLength(IMFGALicenseNumberMaxLength)]
        [Display(Name = "Trainer license")]
        public string IMFGALicenseNumber { get; set; } = null!;
    }
}
