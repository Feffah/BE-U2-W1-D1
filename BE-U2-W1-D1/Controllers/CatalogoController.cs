using BE_U2_W1_D1.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_U2_W1_D1.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ProductService _productService;
        private readonly UserService _userService;
        public CatalogoController(ProductService productService, UserService userService)
        {
            _productService = productService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetAll(); 
            var users = _userService.GetAll();
            ViewBag.Products = products;
            ViewBag.Users = users;

            return View();
        }
    }
}
