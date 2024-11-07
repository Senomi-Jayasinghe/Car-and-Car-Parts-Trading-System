using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Model
{
    public class Car
    {
        public int CarId {  get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int? ColorId { get; set; }
        public decimal FuelEconomy { get; set; }
        public decimal EnginePower { get; set; }
        public DateTime ManufactureDate { get; set; }
        public decimal Price { get; set; }
        public byte[] Picture { get; set; }
        public int EntryUser { get; set; }
        public string EntryDate { get; set; }
    }
}
