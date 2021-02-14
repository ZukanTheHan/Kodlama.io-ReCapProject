using Entities.Concrete; // Bunu da eklemeyi unutma.
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarServices
    {
        // Business katmanı hem DataAccess'ten hem Entities'den veri kullanacağı için önce Project Reference'leri almamız lazım. 
        // Business üzerine sağa tıkla => Add => Project Reference => Click DataAccess - Entities
        List<Car> GetAll();
    }
}
