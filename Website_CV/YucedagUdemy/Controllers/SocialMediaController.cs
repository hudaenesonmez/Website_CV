using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new SocialMediaDal());
        public IActionResult Index()
        {
            var values=socialMediaManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var value=socialMediaManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia socialMedia)
        {
            socialMediaManager.Update(socialMedia);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var value= socialMediaManager.GetById(id);
            socialMediaManager.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            socialMediaManager.Add(socialMedia);
            return RedirectToAction("Index");
        }
    }
}
