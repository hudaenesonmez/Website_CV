using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PortofolioController : Controller
    {
        PortofolioManager portofolioManager=new PortofolioManager(new PortofolioDal());
        public IActionResult Index()
        {
            var values=portofolioManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portofolio portofolio)
        {
            PortfolioValidator validationRules = new PortfolioValidator();
            ValidationResult result=validationRules.Validate(portofolio);
            if(result.IsValid)
            {
                portofolioManager.Add(portofolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                { 
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values=portofolioManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portofolio portofolio)
        {
            PortfolioValidator validationRules = new PortfolioValidator();
            ValidationResult result = validationRules.Validate(portofolio);
            if (result.IsValid)
            {
                portofolioManager.Update(portofolio);

                return RedirectToAction("Index");
            }
            else
            { 
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = portofolioManager.GetById(id);
            portofolioManager.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
