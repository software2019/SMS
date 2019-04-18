using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using SMS.Data.Services;
using SMS.Data.Models;
using SMS.Web.Models;

namespace SMS.Web.Controllers
{
    public class UserController : BaseController
    {
        private readonly IStudentService _svc;

        public UserController()
        {
            _svc = new StudentService();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Username,Password")]UserViewModel m)
        {        
            // call service to locate user
            var user = _svc.GetUserByCredentials(m.Username, m.Password);
            if (user == null)
            {
                ModelState.AddModelError("Username", "Invalid Login Credentials");
                ModelState.AddModelError("Password", "Invalid Login Credentials");
                return View(m);
            }
           
            // sign user in using cookie authentication to store principal
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                BuildClaimsPrincipal(user)
            );

            return RedirectToAction("Index","Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserViewModel m)
        {
            // Validate the UserViewModel. if not valid then return view
            if (!ModelState.IsValid)
            {
                return View(m);
            }

            // call service to register user
            var user = _svc.RegisterUser(m.Username,m.Password,m.Role);
           
            // check if username is unique and if not add a ModelState Error and return view (see login above)
            if (user == null)
            {
                ModelState.AddModelError("Username", "Username is already used - try another");
                return View(m);
            }

            // sign user in using cookie authentication to store principal (see Login above)
             // sign user in using cookie authentication to store principal
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                BuildClaimsPrincipal(user)
            );

            // now redirect to home page
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));
        }

        public IActionResult ErrorNotAuthorised()
        {   
            // create an alert

            return RedirectToAction("Index", "Home");
        }

        public IActionResult ErrorNotAuthenticated()
        {
            // create an alert

            return RedirectToAction("Login", "User"); 
        }

        // Build a claims principal from authenticated user
        private  ClaimsPrincipal BuildClaimsPrincipal(User user)
        { 
            // define user claims
            var claims = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            }, CookieAuthenticationDefaults.AuthenticationScheme);

            // build principal using claims
            return  new ClaimsPrincipal(claims);
        }

    }
}
