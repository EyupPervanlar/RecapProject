﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Brand:IEntity
    {
        [Key] public int BrandId { get; set; }
        public string  BrandName { get; set; }

    }
}
