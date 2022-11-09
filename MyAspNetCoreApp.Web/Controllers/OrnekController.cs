using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class OrnekController : Controller
    {
        public class Product2
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public IActionResult Index()
        {

            ViewBag.name = "Alper";
            ViewData["Age"] = 24; 
            ViewData["names"] = new List<string>() {"Alper",  "Ali",  "Ezgi" };

            TempData["Ad"] = "Alper";
            TempData["Soyad"] = "Aktaş";
            return View();
        }
        public IActionResult Index2()
        {
            var productList = new List<Product2>()
            {
                new(){Id=1,Name="Alper"},
                new(){Id=2,Name="Ali"},
                new(){Id=3,Name="Ezgi"}
            };
            return View(productList);
        }
        public IActionResult Index3()
        {
            return RedirectToAction("Index", "Ornek");
        }
        public IActionResult ContentResult()
        {
            return Content("Alper");
        }
        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "ornek", new { id = id});
        }
        public IActionResult JsonResultParametre(int id)
        {
           return Json(new { Id = 3 });

        }
        public IActionResult JsonResult() 
        {
            return Json(new { Id = 1, Name = "Iphone", Price = "18000" } );
        }
        public IActionResult EmptyResult() 
        {
            return new EmptyResult(); 
        }
    }
}
