using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace YucedagUdemy.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        WriterMessageManager messageManager = new WriterMessageManager(new WriterMessageDal());
        AspNetUserManager<WriterMessage> _userManager;
        public IViewComponentResult Invoke()
        {
            string mail = "admin@gmail.com";
            var values = messageManager.GetRecievedMessages(mail).OrderByDescending(x=>x.WriterMessageId).Take(3).ToList();
            var messaageCount=messageManager.GetRecievedMessages(mail).Count();
            ViewBag.c = messaageCount;
            Context context = new Context();
            

            return View(values);
        }
    }
}
