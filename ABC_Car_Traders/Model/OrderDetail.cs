using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Model
{
    public class OrderDetail
    {
        [Key]
        public int detailId { get; set; }
        public Order Order { get; set; }

        public int? orderId { get; set; }

        public Car Car { get; set; }

        public int? carId { get; set; }
        public CarParts CarParts { get; set; }
        public int? CarPartsId { get; set; }

        public int qty { get; set; }
        public DateTime? created_at { get; set; }

        public String? status { get; set; }
        public int? unitPrice { get; set; }
    }
}
