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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
                _experienceDal = experienceDal;
        }
        public void Add(Experience entity)
        {
           _experienceDal.Add(entity);
        }

        public void Delete(Experience entity)
        {
            _experienceDal.Delete(entity);
        }

        public List<Experience> GetAll()
        {
            return _experienceDal.GetAll();
        }

        public List<Experience> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public Experience GetById(int id)
        {
            return _experienceDal.GetById(e=>e.ExperienceId==id);
        }

        public void Update(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
