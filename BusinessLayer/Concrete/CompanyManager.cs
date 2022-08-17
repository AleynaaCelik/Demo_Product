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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void TDelete(Company t)
        {
            _companyDal.Delete(t);
        }

        public Company TGetById(int id)
        {
            return _companyDal.GetById(id);
        }

        public List<Company> TGetlist()
        {
            return _companyDal.GetList();
        }

        public void TInsert(Company t)
        {
            _companyDal.Insert(t);
        }

        public void TUpdate(Company t)
        {
            _companyDal.Update(t);
        }
    }
}
