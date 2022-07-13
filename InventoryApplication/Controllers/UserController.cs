using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using InventoryApplication.Repository.RepositoryInterface;
using InventoryApplication.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApplication.Controllers
{
    public class UserController : BaseController
    {
        readonly UserRepositoryInterface _userRepo;
        public UserController(UserRepositoryInterface userRepo)
        {
            _userRepo = userRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var user = await _userRepo.GetByUserNameAsync(model.Username);
                if (user == null)
                {
                    Notify("Incorrect Username", notificationType: NotificationType.error);
                    return View(model);
                }
                if (user.Password != model.Password)
                {
                    
                    Notify("Incorrect Password", notificationType: NotificationType.error);
                    return View(model);
                }
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,user.Username)
                    };
                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties { IsPersistent = true,ExpiresUtc=DateTime.Now.AddHours(12) };
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();
                return RedirectToAction("Index", "Product");
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return View(model);
            }
            
        }
        
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
