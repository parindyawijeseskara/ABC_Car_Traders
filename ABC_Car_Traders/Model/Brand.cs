using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Model
{
    public class Brand
    {
        [Key]
        public int brandId {  get; set; }
        public string brandName { get; set; }
    }
}
