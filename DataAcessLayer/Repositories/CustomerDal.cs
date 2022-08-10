using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Repositories
{
    public class CustomerDal : ICustomerDal
    {
        Context c = new Context();
        public void Delete(Customer p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public List<Customer> GetList()
        {
            return c.Customers.ToList();
        }

        public void Insert(Customer p)
        {
            c.Customers.Add(p);
            c.SaveChanges(); 
        }

        public void Update(Customer p)
        {
            c.Customers.Update(p);
            c.SaveChanges();
        }
    }
}
