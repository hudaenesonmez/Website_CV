using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.Services
{
    public class ServiceList : ViewComponent
    {
        ServiceManager serviceManager=new ServiceManager(new ServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.GetAll();
            return View(values);
        }
    }
}
