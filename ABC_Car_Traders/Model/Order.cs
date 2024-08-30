using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Model
{
    public class Order
    {
        [Key]
        public int orderId { get; set; }

        public User User { get; set; }

        public int? userId { get; set; }

        public DateTime? orderDate { get; set; }
        public String? status { get; set; }

        public int? total { get; set; }
    }
}
