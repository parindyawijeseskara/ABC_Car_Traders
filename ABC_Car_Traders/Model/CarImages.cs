using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Model
{
    public class CarImages
    {
        [Key]
        public int imageId { get; set; }
        public byte[] image { get; set; }

        public int carId { get; set; }
        public Car car { get; set; }
    }
}
