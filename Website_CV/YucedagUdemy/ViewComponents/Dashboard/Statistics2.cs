using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace YucedagUdemy.ViewComponents.Dashboard
{
    public class Statistics2 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string mail = "admin@gmail.com";
            ServiceManager serviceManager = new ServiceManager(new ServiceDal());
            WriterMessageManager writerMessageManager = new WriterMessageManager(new WriterMessageDal());
            SkillManager skillManager=new SkillManager(new SkillDal());
            ViewBag.ServiceCount=serviceManager.GetAll().Count;
            ViewBag.MessageCount=writerMessageManager.GetRecievedMessages(mail).Count;
            ViewBag.SkillCount=skillManager.GetAll().Count;
            return View();
        }
    }
}
