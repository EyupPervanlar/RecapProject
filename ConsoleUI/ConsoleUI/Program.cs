﻿using Business.Concrete;
using Business.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using DataAccess.Abstract;



//Car car1 = new Car
//{
//    BrandId = 1,
//    CarName = "Audi A4",
//    ColorId = 1,
//    DailyPrice = 1500,
//    ModelYear = "2020",
//    Description = "Arabaa",
//};

Customer customer1 = new Customer
{
    CompanyName = "Ns"
};
CustomerTest();
CarTest();
//ColorTest();
//BrandTest();
Console.ReadLine();

 void CustomerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    customerManager.add(customer1);
}
static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.getCarDetails();
    foreach (var car in result.Data )//getAll
    {
        Console.WriteLine("CarName: " + car.CarName+ " CarName: " + car.BrandName+" ColorName: "+car.ColorName+ " DailyPrice: "+car.DailyPrice);
    }

}

static void ColorTest()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());
    foreach (var color in colorManager.getAll())
    {
        Console.WriteLine("\nColor: " + color.ColorName);
    }
}

static void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    foreach (var brand in brandManager.getAll())
    {
        Console.WriteLine("Markalar: " + brand.BrandName);
    }
}