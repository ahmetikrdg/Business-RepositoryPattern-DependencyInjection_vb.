using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.webui.Controllers
{
    public class HomeController : Controller
    {   
        private IProductServices _productServices;

        public HomeController(IProductServices productServices)
        {
            this._productServices=productServices;
        }


        public IActionResult Index()
        {         
        
        var productsViewModel = new ProductViewModel
        {
            Products = _productServices.GetAll(),

        };
            return View(productsViewModel);
        }
        public IActionResult Abouth()
        {
            return View();
        }
         public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}