using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace YucedagUdemy.Controllers
{
    [Authorize(Roles = "Admin")]
    public class WriterUserController : Controller
    {
        WriterUserManager writerUserManager =
            new WriterUserManager(new WriterUserDal());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerUserManager.GetAll());
            return Json(values);
        }

    }
}
   
