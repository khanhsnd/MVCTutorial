using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositories;
using Repositories.Interface;

namespace MVCTutorial.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
       
        public ActionResult Index()
        {
            IProductsRepository productsRepository = new ProductsRepository();
            var re = productsRepository.Products_Search();
            return View(re);
        }
    }
}