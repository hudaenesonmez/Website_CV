using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace YucedagUdemy.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new TestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.GetAll();
            return View(values);
        }
    }
}
