using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.Dashboard
{
    public class AdminNavbarNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
