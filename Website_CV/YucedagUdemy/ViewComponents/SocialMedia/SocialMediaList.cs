using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.SocialMedia
{
    public class SocialMediaList:ViewComponent
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new SocialMediaDal());
        public IViewComponentResult Invoke()
        {
            var values = socialMediaManager.GetAll();
            return View(values);
        }
    }
}
