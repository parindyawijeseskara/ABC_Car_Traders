using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ABC_Car_Traders.RegistrationForm;

namespace ABC_Car_Traders.Controllers
{
    public class RegistrationController
    {
        private readonly ApplicationDBContext _context;
        public RegistrationController(ApplicationDBContext context) 
        {
            _context = context;
        }

        public User ValidateUser(string username, string password, int roleId)
        {
            try
            {
                var user = _context.User.FirstOrDefault(u => u.userName == username && u.roleId == roleId);

                if (user != null && PasswordHelper.VerifyPassword(password, user.password))
                {
                    return user;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while validating the user: {ex.Message}");
            }
        }

        public List<Role> GetRoles()
        {
            try
            {
                return _context.Role.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving roles: {ex.Message}");
            }
        }
    }
}
