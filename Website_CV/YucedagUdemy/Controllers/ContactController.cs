using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.Controllers
{ 
    [Authorize(Roles = "Admin")]
public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new MessageDal());
       
        public IActionResult ContactList()
        {
            var values = messageManager.GetAll();
            return View(values);
        }

        public IActionResult ContactMessageDetail(int id)
        {
            var values=messageManager.GetById(id);
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = messageManager.GetById(id);
            messageManager.Delete(values);
            return RedirectToAction("ContactList");
        }

    }
}
