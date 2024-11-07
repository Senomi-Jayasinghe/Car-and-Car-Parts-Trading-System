using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Model
{
    public class CarColor
    {
        public int? ColorId { get; set; }
        public string ColorName { get; set; }
        public override string ToString()
        {
            return ColorName;  // Displayed in DropDown
        }
    }
}
