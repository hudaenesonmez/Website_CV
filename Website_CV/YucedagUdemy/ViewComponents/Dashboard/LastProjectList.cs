using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.Dashboard
{
    public class LastProjectList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PortofolioManager portofolioManager=new PortofolioManager(new PortofolioDal());
            var values=portofolioManager.GetAll();
            return View(values);
        }
    }
}
