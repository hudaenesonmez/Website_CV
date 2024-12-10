using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace YucedagUdemy.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager=new WriterMessageManager(new WriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string mail = "admin@gmail.com";
            var values = writerMessageManager.GetRecievedMessages(mail)
                .OrderByDescending(x=>x.WriterMessageId).Take(5).ToList();
            return View(values);
        }
    }
}
