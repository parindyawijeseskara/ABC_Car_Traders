using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Model
{
    public class Car
    {
        [Key]
        public int carId { get; set; }
        public byte[]? image { get; set; }
        public string? regNo { get; set; }
        public Models? Model { get; set; }
        public int? modelId { get; set; }
        public string? year { get; set; }
        public decimal? price { get; set; }
        public string? description { get; set; }
        public int? quantity { get; set; }
        public string? transmission { get; set; }
        public string? status { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public DateTime? deletedAt { get; set; }


    }
}
