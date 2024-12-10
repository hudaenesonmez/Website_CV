using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YucedagUdemy.ViweComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager=new FeatureManager(new FeatureDal());
        public IViewComponentResult Invoke()
        {
            var values =featureManager.GetAll();
            return View(values);
        }
    }
}
