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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Add(Announcement entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Announcement entity)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.GetAll();
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(x=>x.ID==id);
        }

        public void Update(Announcement entity)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetForNoticications()
        {
            return _announcementDal.GetAll().Take(3).ToList();
        }

        public List<Announcement> GetByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
