using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
