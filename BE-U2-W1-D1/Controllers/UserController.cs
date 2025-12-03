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
            var products = _productService.GetAll();
            return View(products);
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            product.Id = Guid.NewGuid();
            bool isCreated = _productService.Create(product);

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Update(Guid Id)
        {
            var product = _productService.GetId(Id);
            if (product == null)
                return NotFound();
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (product.Id == Guid.Empty)
                return BadRequest("ID non valido.");


            var productFromDb = _productService.GetId(product.Id);
            if (productFromDb == null)
                return NotFound();


            productFromDb.Titolo = product.Titolo;
            productFromDb.Autore = product.Autore;
            productFromDb.Prezzo = product.Prezzo;
            productFromDb.Copertina = product.Copertina;



            bool updated = _productService.Update(productFromDb);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            bool result = _productService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
