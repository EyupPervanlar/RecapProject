﻿using Core.Entites;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Car:IEntity
    {

        [Key] public int CarId { get; set; }
        public int BrandId {  get; set; }
        public int ColorId {  get; set; }
        public string CarName { get; set; }
        public string ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }


    }
}
