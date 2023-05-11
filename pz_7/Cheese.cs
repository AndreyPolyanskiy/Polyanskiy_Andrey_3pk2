using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    class Cheese : Product
    {
        public Cheese()
        {
            Name = "Сыр";
            Price = 160;
        }

        public override double GetDiscount(double totalPurchases)
        {
            return 0;
        }
    }
}
