using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : IGenericService<Customer>
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetCustomerListWithCompany()
        {
            return _customerDal.GetCustomerListWithCompany();
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetlist()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}
