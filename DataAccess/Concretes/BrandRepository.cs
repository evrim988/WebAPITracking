using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class BrandRepository : IBrandRepository
    {
        List<Brand> _brands;
        public BrandRepository()
        {
            _brands = new List<Brand>();
            _brands.Add(new Brand { ID = 1, Name = "Fiat", CreatedDate = DateTime.Now });
            _brands.Add(new Brand { ID = 2, Name = "Opel", CreatedDate = DateTime.Now });
            _brands.Add(new Brand { ID = 3, Name = "Mercedes", CreatedDate = DateTime.Now });
        }
        public void Add(Brand model)
        {
            _brands.Add(model);
        }

        public List<Brand> GetList()
        {
            return _brands;
        }
    }
}
