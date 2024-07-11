using PdksApp.Bussines.Abstract;
using PdksApp.DAL;
using PdksApp.WinForm;
using System.Collections.Generic;
using System.Linq;

namespace PdksApp.Bussines.Concrete
{
    public class UserService : IUserService
    {
        readonly AppDbContext _context;
        public UserService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Add(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public void Remove(User entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }


        public void Update(User entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

    }
}
