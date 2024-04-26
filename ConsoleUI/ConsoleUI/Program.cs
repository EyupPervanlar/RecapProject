using Business.Concrete;
using Business.Abstract;
using DataAccess.Concrete.InMemory;
CarManager carManager=new CarManager(new InMemoryCarDal());
foreach (var car in carManager.getAll())
{
    Console.WriteLine(car.BrandId);
}
Console.ReadLine();