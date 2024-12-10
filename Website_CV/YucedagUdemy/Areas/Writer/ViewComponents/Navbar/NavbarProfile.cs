using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace YucedagUdemy.Areas.Writer.ViewComponents.Navbar
{
    public class NavbarProfile:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public NavbarProfile(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Image=values.ImageUrl;
            ViewBag.Name=values.Name;
            return View();
        }
    }
}
