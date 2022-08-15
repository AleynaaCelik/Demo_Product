using BusinessLayer.Concrete;
using BusinessLayer.FluentValidition;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productmanager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productmanager.TGetlist();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ProductValidatior validationRules = new ProductValidatior();
            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                productmanager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
