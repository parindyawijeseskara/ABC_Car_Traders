using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Model
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        public int roleId { get; set; }
        public string firstName { get; set; }
        public string lastName {  get; set; }
        public string nic { get; set; }
        public string address { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public Role Role { get; set; }
    }
}
