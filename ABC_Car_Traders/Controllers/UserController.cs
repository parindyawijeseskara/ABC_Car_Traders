using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                //.Where(user => user.deletedAt == null)
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
                existingUser.status = "ACT";
                existingUser.userName = user.userName;
                existingUser.password = user.password;
              //  existingUser.roleId = user.roleId;
                _context.SaveChanges();
            }

        } 

        public void deleteUser(int userId)
        {
            var user = _context.User.Find(userId);
            if (user != null)
            {
                user.deletedAt = DateTime.Now;
                user.status = "INACT";
                _context.SaveChanges();
            }
        }

        //get all customers by email
        public List<User> GetCustomersByEmail(string email)
        {
            return _context.User
                .Where(user => user.email.Contains(email))
                .ToList();
        }

        //get all customers by status
        public List<dynamic> GetCustomersByStatus(string status)
        {
            return _context.User
             .Where(user => user.deletedAt == null && user.status == status)
             .Select(car => new {
                 
                 car.status
             })
             .ToList<dynamic>();
        }
        
    }
}
