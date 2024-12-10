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
    public class WriterUserManager:IWriterUserService
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void Add(WriterUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WriterUser entity)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> GetAll()
        {
            return _writerUserDal.GetAll();
        }

        public List<WriterUser> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public WriterUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(WriterUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
