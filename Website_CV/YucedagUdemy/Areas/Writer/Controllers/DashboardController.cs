using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YucedagUdemy.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values= await _userManager.FindByNameAsync(User.Identity.Name);
            string recievedMessage = values.Email;
            //Weather API
            string api = "de8dd5d928c761fe501b94378608f59c";
            string connection =
          "https://api.openweathermap.org/data/2.5/weather?q=%C4%B0stanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.w=document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //ViewBag
            ViewBag.v1 = "Yazar Paneli";
            ViewBag.v2 = "Dashboard";
            ViewBag.v3 = "Dashboard Paneli";

            ViewBag.N=values.Name +" " + values.Surname;
            Context c=  new Context();
            ViewBag.d1 = c.WriterMessages.Where(x=>x.Receiver==recievedMessage).Count();
            ViewBag.d2 = c.Announcements.Count();
            ViewBag.d3 = c.Users.Count();
            return View();
        }
        
    }
}
