using Microsoft.AspNetCore.Mvc;
using iCart.Models ;

namespace iCart.Controllers
{
   [Route("product")]
    public class ProductController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }
    }
}