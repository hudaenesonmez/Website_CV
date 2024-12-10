using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace YucedagUdemy.Areas.Writer.ViewComponents.Notification
{
    public class NotificationList:ViewComponent
    {
        AnnouncementManager announcementManager=new AnnouncementManager(new AnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values=announcementManager.GetForNoticications();
            return View(values);
        }

    }
}
