namespace MountainTrainingApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using  Services.Data.Interfaces;
    using static Infrastructure.Extensions.ClaimsPrincipalExtensions;
    using static Common.NotificationMessagesConstants;
    using Web.ViewModels.Trainer;
    [Authorize]
    public class TrainerController : Controller
    {
        private readonly ITrainerService trainerService;
        public TrainerController(ITrainerService trainerService)
        {
            this.trainerService = trainerService;
        }

        [HttpGet]
        public async Task<IActionResult> RegisterTrainer()
        {
            string userId = User.GetUserId();

            bool isTrainer=await trainerService
                .TainerExistByUserIdAsync(userId);

            if (isTrainer)
            {
                TempData[ErrorMesage] = "You are already a trainer!";
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterTrainer(RegisterTrainerViewModel model)
        {
            string userId = User.GetUserId();

            bool isTrainer = await trainerService
                .TainerExistByUserIdAsync(userId);

            if (isTrainer)
            {
                TempData[ErrorMesage] = "You are already a trainer!";
                return RedirectToAction("Index", "Home");
            }

            bool isLicenseTaken=await trainerService
                .TarnerExisByIMFGALicenseNumberIdAsync(model.IMFGALicenseNumber);
            if (isLicenseTaken) 
            {
                ModelState.AddModelError(nameof(model.IMFGALicenseNumber), "Trainer with the provided name already exist!");
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await trainerService.CreateTrainerAsync(userId,model);
            }
            catch (Exception)
            {

                TempData[ErrorMesage] = "Unexpected error occurred while register you as a Trainer." +
                    "Please try again later or contact administrator";

                return RedirectToAction("Index", "Home");
            }


            return RedirectToAction("Index", "Home");

        }
    }
}
