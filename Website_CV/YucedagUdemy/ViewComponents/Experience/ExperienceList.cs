using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experienceManager=new ExperienceManager(new ExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experienceManager.GetAll();
            return View(values);
        }
    }
}
