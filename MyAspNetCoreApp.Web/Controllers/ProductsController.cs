using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Web.Models;
using System.Xml.Linq;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ProductsController : Controller
    {
        public readonly ProductRepository _productsRepository;   /// bu metod Modelde tanımlanan listeye burada değer atamamıza yardımcı olur.
        public ProductsController() 
        {
            _productsRepository = new ProductRepository(); 
            
        }
        public IActionResult Index()
        {
            var products = _productsRepository.GetAll();
            return View(products);
        }
        public IActionResult Remove(int id)
        {
            _productsRepository.Remove(id);
            return RedirectToAction("Index");
        }
        public IActionResult Add() 
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            return View();
        }
    }
}
