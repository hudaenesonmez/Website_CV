using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager contactManager=new ContactManager(new ContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.GetAll();
            return View(values);
        }
    }
}
