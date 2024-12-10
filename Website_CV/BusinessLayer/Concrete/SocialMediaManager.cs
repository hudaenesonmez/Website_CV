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
    public class SocialMediaManager:ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void Add(SocialMedia entity)
        {
            _socialMediaDal.Add(entity);
        }

        public void Delete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public List<SocialMedia> GetAll()
        {
            return _socialMediaDal.GetAll();
        }

        public List<SocialMedia> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.GetById(x => x.SocialMediaId == id);
        }

        public void Update(SocialMedia entity)
        {
           _socialMediaDal.Update(entity);
        }
    }
}
