using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T880809.Models {
    public class SampleOrder {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int ShipCountry { get; set; }
        public int ShipCity { get; set; }
    }
}
