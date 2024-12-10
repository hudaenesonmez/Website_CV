using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ToDoListManager toDoListManager = new ToDoListManager(new ToDoListDal());
            var values = toDoListManager.GetAll();
            return View(values);
        }
    }
}
