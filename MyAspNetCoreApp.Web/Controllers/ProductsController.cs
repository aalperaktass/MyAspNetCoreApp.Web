using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Web.Models;
using System.Xml.Linq;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ProductsController : Controller
    {
        private AppDbContext _context;

        public readonly ProductRepository _productsRepository;   /// bu metod Modelde tanımlanan listeye burada değer atamamıza yardımcı olur.
       
        public ProductsController(AppDbContext context) 
        {
            _productsRepository = new ProductRepository(); 
            _context = context;

            if (!_context.Products.Any())
            {
                _context.Products.Add(new Product() { Name = "Kalem1", Price = 100, Stock = 100 });
                _context.Products.Add(new Product() { Name = "Kalem2", Price = 110, Stock = 200 });
                _context.Products.Add(new Product() { Name = "Kalem3", Price = 102, Stock = 300 });

                _context.SaveChanges();
            }
            


        }
        public IActionResult Index()
        {
            var products = _context.Products.ToList(); 
            return View(products);
        }
        public IActionResult Remove(int id)
        {
            var product = _context.Products.Find(id);
           
            _context.Products.Remove(product);

            _context.SaveChanges();
            
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
