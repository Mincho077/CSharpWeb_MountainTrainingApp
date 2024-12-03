namespace MountainTrainingApp.Web.ViewModels.Trainer
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.TrainerConstats;
    public class RegisterTrainerViewModel
    {
        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        [Display(Name = "Trainer name")]
        public string Name { get; set; } = null!;
    }
}
