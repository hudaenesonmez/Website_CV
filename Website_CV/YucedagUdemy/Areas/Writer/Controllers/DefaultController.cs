using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new AnnouncementDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Yazar Paneli";
            ViewBag.v2 = "Duyurular";
            ViewBag.v3 = "Tüm Duyurular";
            var results=announcementManager.GetAll();
            return View(results);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            ViewBag.v1 = "Yazar Paneli";
            ViewBag.v2 = "Duyurular";
            ViewBag.v3 = "Duyuru Detayları";
            ViewBag.v4 = "/Writer/Default/Index";
            var announcement = announcementManager.GetById(id);
            return View(announcement);
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialSideBar()
        {
        return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }


    }
}
