using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    class Milk : Product
    {
        public Milk()
        {
            Name = "Молоко";
            Price = 70;
        }

        public override double GetDiscount(double totalPurchases)
        {
            if (totalPurchases > 10)
            {
                return 0.2 * Price;
            }

            return 0;
        }
    }
}
