﻿using Core.Entites;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class ColorI:IEntity
    {
        [Key]
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
