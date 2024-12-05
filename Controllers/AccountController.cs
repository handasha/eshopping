using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Mvc;
using EShoppingApp.Models;

namespace EShoppingApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            // Show the login view with options (e.g., login form, Facebook login button)
            return View();
        }

        public IActionResult Register()
        {
            // Show the registration view
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            // Add logic to save user in the database
            return RedirectToAction("Login");
        }

        public IActionResult FacebookLogin()
        {
            // Redirects the user to Facebook for authentication
            return Challenge(new AuthenticationProperties { RedirectUri = "/Account/FacebookCallback" }, FacebookDefaults.AuthenticationScheme);
        }

        public async Task<IActionResult> FacebookCallback()
        {
            // Retrieve user information from the authentication cookie
            var result = await HttpContext.AuthenticateAsync();

            if (result?.Principal != null)
            {
                // Extract user details from claims
                var name = result.Principal.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;
                var email = result.Principal.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value;

                // Optionally save or update the user in the database
                // e.g., Check if the user exists, create a new account, etc.

                return RedirectToAction("Index", "Home"); // Redirect to home or dashboard
            }

            // If authentication failed, redirect to login
            return RedirectToAction("Login");
        }
    }
}
