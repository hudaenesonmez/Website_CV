using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.Portofolio
{
    public class PortofolioList : ViewComponent
    {
        PortofolioManager portofolioManager = new PortofolioManager(new PortofolioDal());
        public IViewComponentResult Invoke()
        {
            var values=portofolioManager.GetAll();
            return View(values);
        }
    }
}
