using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.Skill
{
    public class SkillList : ViewComponent
        { 
        SkillManager skillManager=new SkillManager(new SkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.GetAll();
            return View(values);
        }
    }
}
