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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featuredal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featuredal = featureDal;
        }
        public void Add(Feature entity)
        {
            _featuredal.Add(entity);    
        }

        public void Delete(Feature entity)
        {
            _featuredal.Delete(entity);
        }

        public List<Feature> GetAll()
        {
            return _featuredal.GetAll();
        }

        public List<Feature> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public Feature GetById(int id)
        {
            return _featuredal.GetById(f=>f.FeatureId==id);
        }

        public void Update(Feature entity)
        {
            _featuredal.Update(entity);
        }
    }
}
