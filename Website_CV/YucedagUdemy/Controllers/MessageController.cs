using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace YucedagUdemy.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new WriterMessageDal());
        string _mail="admin@gmail.com";
            
        public IActionResult RecievedAdminMessages()
        {
            
            var values=writerMessageManager.GetRecievedMessages(_mail);
            return View(values);
        }
        public IActionResult SendedAdminMessages()
        {
            
            var values = writerMessageManager.GetSendedMessages(_mail);
            return View(values);
        }
        public IActionResult AdminRecievedMessageDetails(int id)
        {
            var values=writerMessageManager.GetById(id);
            return View(values);
        }
        public IActionResult AdminSendedMessageDetails(int id)
        {
            var values = writerMessageManager.GetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(WriterMessage p)
        {
            p.Sender=_mail;
            p.SenderName = "Admin";
            p.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c= new Context();
            var recieverName=c.Users.Where(x=>x.Email==p.Receiver).Select(p=>p.Name+" "+p.Surname).FirstOrDefault();
            p.ReceiverName=recieverName;
            writerMessageManager.Add(p);
            return RedirectToAction("SendedAdminMessages");
        }
    }
}
