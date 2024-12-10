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
    public class PortofolioManager : IPortofolioService
    {
        IPortofolioDal _portofolioDal;
        public PortofolioManager(IPortofolioDal portofolioDal)
        {
                _portofolioDal = portofolioDal;
        }
        public void Add(Portofolio entity)
        {
            _portofolioDal.Add(entity);
        }

        public void Delete(Portofolio entity)
        {
            _portofolioDal.Delete(entity);
        }

        public List<Portofolio> GetAll()
        {
            return _portofolioDal.GetAll();
        }

        public List<Portofolio> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public Portofolio GetById(int id)
        {
            return _portofolioDal.GetById(p=>p.PortofolioId==id);
        }

        public void Update(Portofolio entity)
        {
           _portofolioDal.Update(entity);
        }
    }
}
