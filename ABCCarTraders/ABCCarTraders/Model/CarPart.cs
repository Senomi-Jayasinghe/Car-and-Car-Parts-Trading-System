using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Model
{
    public class CarPart
    {
        public int CarPartId { get; set; }
        public string Name { get; set; }
        public int CarId { get; set; }
        public DateTime ManufactureDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? ColorId { get; set; }
        public byte[] Picture { get; set; }
        public int EntryUser { get; set; }
        public string EntryDate { get; set; }

    }
}
