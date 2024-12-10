using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace YucedagUdemy.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
