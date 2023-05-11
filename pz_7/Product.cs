using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public abstract double GetDiscount(double totalPurchases);
    }
}
