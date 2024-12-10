using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;
using YucedagUdemy.Areas.Writer.Models;

namespace YucedagUdemy.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area ("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                WriterUser writerUser = new WriterUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    ImageUrl = p.ImageUrl,
                    UserName = p.Username,
                    Email = p.Email
                };
                if(p.Password==p.ConfirmPassword)
                { 
                var result = await _userManager.CreateAsync(writerUser, p.Password);
                if (result.Succeeded)
                {
                    RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                }
            }
            return View(p);
        }
    }
}
//123456Aa*
//enessonmez1
