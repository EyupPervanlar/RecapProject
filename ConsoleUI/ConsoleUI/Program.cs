using Business.Concrete;
using Business.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using DataAccess.Abstract;
CarManager carManager=new CarManager(new EfCarDal());
ColorManager colorManager=new ColorManager(new EfColorDal());
BrandManager brandManager=new Business.Concrete.BrandManager(new EfBrandDal());
Car car1 = new Car {
    BrandId = 1, CarName = "Audi A4", ColorId = 1, DailyPrice = 1500, ModelYear = "2020",Description="Arabaa",
};
carManager.Add(car1);
//foreach (var car in carManager.getAll())
//{
//    Console.WriteLine("Arabalar: "+car.CarName);
//}
//foreach (var color in colorManager.getAll())
//{
//    Console.WriteLine("\nColor: "+color.ColorName);
//}
//foreach(var brand in brandManager.getAll())
//{
//    Console.WriteLine("Markalar: "+brand.BrandName);
//}
Console.ReadLine();