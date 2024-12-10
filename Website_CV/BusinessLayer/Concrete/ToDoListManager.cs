using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;
        public ToDoListManager(IToDoListDal toDoListDal)
        {
              _toDoListDal = toDoListDal;
        }
        public void Add(ToDoList entity)
        {
            _toDoListDal.Add(entity);
        }

        public void Delete(ToDoList entity)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> GetAll()
        {
            return _toDoListDal.GetAll();
        }

        public List<ToDoList> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public ToDoList GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ToDoList entity)
        {
            throw new NotImplementedException();
        }
    }
}
