using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BOL;
using BOL.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Bookmakers.Controllers
{
    public class AccountController : BaseController
    {
        public AccountController(BookmakersContext context) : base(context)
        { }

        [HttpGet]
        public IActionResult Login()
        {
            return View("Authorization");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            User getAuthUser = db.UserDb
                .GetAll().FirstOrDefault(x => x.UserEmail == user.UserEmail && x.Password == user.Password);
            if (getAuthUser != null)
            {
                user.Role = db.RoleDb.GetById(db.UserDb.GetById(user.UserEmail).RoleId);
                Authenticate(user);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Invalid username or password");
            return View("Authorization", user);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                bool checkForExistingUser = db.UserDb.GetAll().FirstOrDefault(x => x.UserEmail == user.UserEmail) == null;
                if (checkForExistingUser)
                {
                    // ReSharper disable once PossibleNullReferenceException
                    user.RoleId = db.RoleDb.GetAll().FirstOrDefault(x => x.RoleName == "User").RoleId;
                    user.Role = db.RoleDb.GetById(user.RoleId);
                    db.UserDb.Insert(user);
                    Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "This user already exist");
                }
            }

            return View("Register");
        }

        public IActionResult SignOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        private void Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserEmail),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.RoleName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}