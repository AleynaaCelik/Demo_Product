using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
   public  interface IProductDal_
    {
        void Insert(Product p);
        void Delete(Product p);
        void Update(Product p);
        List<Product> GetList();
    }
}
