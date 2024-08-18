using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Controllers
{
    public class UserController
    {
        private readonly ApplicationDBContext _context;
        public UserController(ApplicationDBContext context) 
        { 
            _context = context;
        }

        public void AddUser(User user)
        {
            user.createdAt = DateTime.Now;
            user.updatedAt = DateTime.Now;
            _context.User.Add(user);
            _context.SaveChanges();

        }

        public List<dynamic> GetAllUsers()
        {
            return _context.User
                .Where(user => user.deletedAt == null)
                .Select(user => new
                {
                    user.userId,
                    user.firstName,
                    user.email,
                    user.address,
                    user.contactNo,
                    user.nic,
                    user.status
                })
                .ToList<dynamic>();
        }

        public List<dynamic> GetUsers()
        {
            return _context.User
                .Where(user => user.deletedAt == null)
                .Select(user => new
                {
                    user.userId,
                    user.firstName,
                    user.email,
                    //user.roleId,
                    role = user.Role.role,
                    //user.createdAt,
                    createdAt = user.createdAt.ToString("yyyy-MM-dd"),
                    user.status
                })
                .ToList<dynamic>();

        }

        public User getUserById(int userId)
        {
            return _context.User.Find(userId);
        }

        public List<Role> GetAllRoles()
        {
            return _context.Role.ToList();
        }

        public void updateUser(User user)
        {
            user.updatedAt = DateTime.Now;
            var existingUser = _context.User.Find(user.userId);
            if (existingUser != null)
            {
                existingUser.firstName = user.firstName;
                existingUser.lastName = user.lastName;
                existingUser.email = user.email;
                existingUser.address = user.address;
                existingUser.contactNo = user.contactNo;
                existingUser.nic = user.nic;
                existingUser.status = user.status;
                existingUser.userName = user.userName;
                existingUser.password = user.password;
                existingUser.roleId = user.roleId;
                _context.SaveChanges();
            }

        } 

        public void deleteUser(int userId)
        {
            var user = _context.User.Find(userId);
            if (user != null)
            {
                user.deletedAt = DateTime.Now;
                _context.SaveChanges();
            }
        }
        
    }
}
