using BE_U2_W1_D1.Models.Entity;
using BE_U2_W1_D1.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_U2_W1_D1.Models.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            this._context = context;
        }
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        public User GetId(Guid Id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == Id);
        }

        public List<User> GetAll()
        {
            return this._context.Users.ToList();
        }

        public bool Create(User user)
        {
            this._context.Users.Add(user);

            if (this._context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
   

}
