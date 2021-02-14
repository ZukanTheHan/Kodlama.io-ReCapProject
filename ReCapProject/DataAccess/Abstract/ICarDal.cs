using Entities.Concrete;  // Bunu da eklemeyi unutmayın.
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        // Bu GetAll operasyonu için önce Entities katmanından referans almamız lazım.
        // Bunu da Data-Accesse sağ tıklayıp Add => Project Reference => Click-Entities yoluyla yapıyoruz
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<Car> GetById(int iD); // Id'ye göre sıralama yapacak


    }
}
