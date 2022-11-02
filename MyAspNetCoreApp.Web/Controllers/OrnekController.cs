using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContentResult()
        {
            return Content("Alper");
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
