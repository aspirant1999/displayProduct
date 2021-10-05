using displayProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace displayProduct.Controllers
{
   
    public class testController : Controller
    {
        
        // GET: test
        public ActionResult Index()
        {
            testEntities DB = new testEntities();

            List<Product> products = DB.Product.ToList();

            return View(products);
        }
    }
}