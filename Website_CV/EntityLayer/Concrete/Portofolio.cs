using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portofolio : IEntity
    {
        [Key]
        public int PortofolioId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string ImageFullUrl { get; set; }
        public string Url { get; set; }
        public string HrefUrl { get; set; }
        public string Platform { get; set; }
        public bool Status {  get; set; }
        public string PlatformLogoUrl { get; set; }

    }
}
