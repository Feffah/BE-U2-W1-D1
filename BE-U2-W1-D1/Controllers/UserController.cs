using BE_U2_W1_D1.Models.Services;
using BE_U2_W1_D1.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BE_U2_W1_D1.Controllers
{
    public class UserController : Controller
    {
        private readonly ProductService _productService;

        public UserController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            product.Id = Guid.NewGuid();
            bool isCreated = _productService.Create(product);


            return View(product);

        }
    }
}
