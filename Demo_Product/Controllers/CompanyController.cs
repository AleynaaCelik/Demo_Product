using BusinessLayer.Concrete;
using BusinessLayer.FluentValidition;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
    public class CompanyController : Controller
    {
       CompanyManager companymanager = new CompanyManager(new EfCompanyDal());
        public IActionResult Index()
        {
            var values = companymanager.TGetlist();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCompany(Company p)
        {
                companymanager.TInsert(p);
                return RedirectToAction("Index");  
            
        }
        public IActionResult DeleteCompany(int id)
        {
            var value = companymanager.TGetById(id);
            companymanager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCompany(int id)
        {
            var value = companymanager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCompany(Company p)
        {

            companymanager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}

