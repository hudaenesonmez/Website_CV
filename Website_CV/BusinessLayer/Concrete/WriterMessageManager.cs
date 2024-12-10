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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public void Add(WriterMessage entity)
        {
            _writerMessageDal.Add(entity);
        }

        public void Delete(WriterMessage entity)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> GetAll()
        {
            return _writerMessageDal.GetAll();
        }

        public List<WriterMessage> GetByFilter(string p)
        {
            return _writerMessageDal.GetByFilter(x=>x.Receiver==p);
        }

        public List<WriterMessage> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public WriterMessage GetById(int id)
        {
            return _writerMessageDal.GetById(x => x.WriterMessageId == id);
        }

        public List<WriterMessage> GetRecievedMessages(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetSendedMessages(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Sender == p);
        }

        public void Update(WriterMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}
