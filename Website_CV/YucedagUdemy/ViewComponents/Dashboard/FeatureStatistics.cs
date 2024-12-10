using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace YucedagUdemy.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SkillManager skillManager = new SkillManager(new SkillDal());
            PortofolioManager portofolioManager=new PortofolioManager(new PortofolioDal());
            MessageManager messageManager=new MessageManager(new MessageDal());
            ViewBag.SkillCount = skillManager.GetAll().Count;
            ViewBag.ProjectCount=portofolioManager.GetAll().Count;
            ViewBag.SeenMessage=messageManager.GetAll().Where(x=>x.Status==true).Count();
            ViewBag.UnseenMessage=messageManager.GetAll().Where(x=> x.Status==false).Count();
            return View();
        }
    }
}
