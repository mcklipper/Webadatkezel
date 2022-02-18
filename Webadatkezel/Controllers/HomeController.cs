using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Webadatkezel.Data;
using Webadatkezel.Models;

namespace Webadatkezel.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(
            ApplicationDbContext context, 
            UserManager<IdentityUser> userManager) 
        {
            this.context = context;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var id = userManager.GetUserId(HttpContext.User);
            var products = context
                .Products
                .Where(x => x.User.Id == id)
                .ToList();

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}