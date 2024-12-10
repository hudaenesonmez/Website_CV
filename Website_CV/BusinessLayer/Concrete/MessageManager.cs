﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void Add(Message entity)
        {
            _messageDal.Add(entity);
        }

        public void Delete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }

        public List<Message> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(m=>m.MessageId==id);
        }

        public void Update(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}
