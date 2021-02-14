using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarServices
    {
        ICarDal _carDal;   // Burada bir constructor tanımlıyoruz. Bu sayede programımıza fonksiyonellik kazandırdık.

       

        // Başka bir sistem kullandığımızda business katmanında değişiklik yapmamıza gerek kalmayacak
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
