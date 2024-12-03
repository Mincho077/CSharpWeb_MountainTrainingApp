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
                TempData[ErrorMesage] = "Нали се регистрира ве,кретен!";
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
                TempData[ErrorMesage] = "Нали се регистрира ве,кретен!";
                return RedirectToAction("Index", "Home");
            }

            bool isNameTaken=await trainerService
                .TarnerExistNameIdAsync(model.Name);
            if (isNameTaken) 
            {
                ModelState.AddModelError(nameof(model.Name), "Мноо си прост ве пич,има вече такова име!");
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
