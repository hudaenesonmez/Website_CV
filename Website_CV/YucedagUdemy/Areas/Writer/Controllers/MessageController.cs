using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace YucedagUdemy.Areas.Writer.Controllers
{
    [Area ("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager _messageManager=new WriterMessageManager(new WriterMessageDal());
        UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("RecievedMessage")]
        public async Task<IActionResult> RecievedMessage(string p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p=user.Email;
            var values=_messageManager.GetRecievedMessages(p);
            return View(values);
        }
        [Route("")]
        [Route("SendedMessage")]
        public async Task<IActionResult> SendedMessage(string p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p = user.Email;
            var values = _messageManager.GetSendedMessages(p);
            return View(values);
        }
        [HttpGet]
        [Route("SendedMessageDetails/{id}")]
        public IActionResult SendedMessageDetails(int id)
        {
            ViewBag.v1 = "Yazar Paneli";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Mesajı Oku";
            ViewBag.v4 = "/Writer/Message/RecievedMessage";
            var message = _messageManager.GetById(id);
            return View(message);
        }
        [HttpGet]
        [Route("RecievedMessageDetails/{id}")]
        public IActionResult RecievedMessageDetails(int id)
        {
            ViewBag.v1 = "Yazar Paneli";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Mesajı Oku";
            ViewBag.v4 = "/Writer/Message/RecievedMessage";
            var message = _messageManager.GetById(id);
            return View(message);
        }

        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            ViewBag.v1 = "Yazar Paneli";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Mesajı Gönder";
            ViewBag.v4 = "/Writer/Message/RecievedMessage";
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            ViewBag.v1 = "Yazar Paneli";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Mesajı Gönder";
            ViewBag.v4 = "/Writer/Message/RecievedMessage";
            //Send Message
            var values=await _userManager.FindByNameAsync(User.Identity.Name);
            string mail=values.Email;
            string name=values.Name+" "+values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            //Alıcının adını bulma
            Context context = new Context();
            var recieverNameSurname=context.Users.Where(x=>x.Email==p.Receiver).Select(y=>y.Name+" "+y.Surname).FirstOrDefault();
            p.ReceiverName = recieverNameSurname;
                _messageManager.Add(p);
            return RedirectToAction("SendedMessage");
            
        }
    }
}
