using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Model
{
    public class Payment
    {
        [Key]
        public int paymentId { get; set; }
        public Order Order { get; set; }

        public int? orderId { get; set; }

        public DateTime? paymentDate { get; set; }

        public string status { get; set; }
    }
}
