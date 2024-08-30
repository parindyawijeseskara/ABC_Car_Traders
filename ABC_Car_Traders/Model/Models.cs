using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Model
{
    public class Models
    {
        [Key]
        public int modelId { get; set; }
        public string modelName { get; set; }
        public Brand Brand { get; set; }

        public int brandId { get; set; }
    }
}
