﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class CarDetailsDto:IDto
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName{ get; set; }
        public int DailyPrice { get; set; }
    }
}
