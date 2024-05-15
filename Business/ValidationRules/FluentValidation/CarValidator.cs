using Entites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator() 
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c=>c.DailyPrice).GreaterThan(10);
            RuleFor(p => p.ModelYear).NotEmpty();
           
  
        }
    }
}
