using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new ServiceDal());
        public IActionResult Index()
        {

            var values=serviceManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.Add(service);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values=serviceManager.GetById(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.Update(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.GetById(id);
            serviceManager.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
