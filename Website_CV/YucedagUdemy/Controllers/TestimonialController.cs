using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new TestimonialDal());
        public IActionResult Index()
        {
            var values=testimonialManager.GetAll();
            return View(values);
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var testimonial=testimonialManager.GetById(id);
            testimonialManager.Delete(testimonial);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult TestimonialDetails(int id)
        {
            var testimonial = testimonialManager.GetById(id);
            return View(testimonial);
        }
        [HttpPost]
        public IActionResult TestimonialDetails(Testimonial testimonial)
        {
            testimonialManager.Update(testimonial);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View(); }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            if(testimonial.ImageUrl == null)
            {
                testimonial.ImageUrl = "~/Template/images/icondefaultimage.png";
            }
            testimonialManager.Add(testimonial);
            return RedirectToAction("Index");
        }
    }
}
