using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    class Bread : Product
    {
        public Bread()
        {
            Name = "Хлеб";
            Price = 24;
        }

        public override double GetDiscount(double totalPurchases)
        {
            if (totalPurchases > 5)
            {
                return 0.1 * Price;
            }

            return 0;
        }
    }
}
