using BE_U2_W1_D1.Models.Entity;
using BE_U2_W1_D1.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_U2_W1_D1.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var users = this._userService.GetAll();
            return View(users);
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            user.Id = Guid.NewGuid();
            bool isCreated = this._userService.Create(user);

            var users = this._userService.GetAll();


            return View(users);

        }
    }
}
