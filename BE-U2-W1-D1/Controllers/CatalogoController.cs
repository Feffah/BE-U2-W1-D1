using BE_U2_W1_D1.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_U2_W1_D1.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ProductService _productService;
        public CatalogoController(ProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }
    }
}
