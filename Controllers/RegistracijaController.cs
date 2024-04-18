using DSR_KAZAR_N1.Models;
using DSR_KAZAR_N1.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DSR_KAZAR_N1.Controllers
{
    public class RegistracijaController : Controller
    {
        private readonly SignInManager<UporabnikZGesli> _signInManager;
        private readonly UserManager<UporabnikZGesli> _userManager;

        public RegistracijaController(SignInManager<UporabnikZGesli> signInManager, UserManager<UporabnikZGesli> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Name, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Uporabnkško ime in geslo se ne ujemata");
                return View(model);
            }
            return View(model);
        }
        [HttpPost]

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index));
        }



        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(page1Model model1, page2Model model2, page3Model model3)
        {
            UporabnikZGesli User = new UporabnikZGesli(
            model1.name,
            model1.surname,
            model1.birthdate,
            model1.birthplace,
            model1.emso,
            model2.address,
            model2.post,
            model2.postnum,
            model2.country,
            model3.email,
            model3.password,
            model3.password2
            );

            if (ModelState.IsValid)
            {
                User.UserName = model1.name + "" + model1.surname;
                User.Email = model3.email;
                _userManager.AddToRoleAsync(User, "User");
                var result = await _userManager.CreateAsync(User, model3.password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(User, false);
                }
                else


                    TempData["User"] = JsonSerializer.Serialize(User);
                TempData.Keep();



                return RedirectToAction("novUporabnik");

            }
            else
                return RedirectToAction();

        }

        public IActionResult novUporabnik(UporabnikZGesli user)
        {
            if (User.IsInRole("User") || User.IsInRole("Admin"))
            {
                return View(user);
            }
            return RedirectToAction("Index");
        }
    }
}
