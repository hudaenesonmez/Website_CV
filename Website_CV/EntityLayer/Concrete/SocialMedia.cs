﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SocialMedia : IEntity
    {
        [Key]
        public int SocialMediaId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
        public bool Status { get; set; }
    }
}