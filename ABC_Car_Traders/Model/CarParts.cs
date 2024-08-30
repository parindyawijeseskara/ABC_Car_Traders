using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Model
{
    public class CarParts
    {
        [Key]
        public int carPartId { get; set; }
        public string carPartName { get; set;}
        public byte[] image { get; set;}
        public Models Model { get; set; }
        public int modelId { get; set; }
        public decimal price { get; set;}
        public int quantity { get; set;}
        public string description { get; set;}
        public string manufacturer { get; set;}
        public string warrantyPeriod { get; set;}
        public string status { get; set;}
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime? deletedAt { get; set; }
    }
}
