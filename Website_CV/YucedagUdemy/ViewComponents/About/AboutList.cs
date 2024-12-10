using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.About
{
    public class AboutList :ViewComponent
    {
        AboutManager aboutManager=new AboutManager(new AboutDal());
        public IViewComponentResult Invoke()
        {
            var values=aboutManager.GetAll();
            return View(values);
        }
    }
}
