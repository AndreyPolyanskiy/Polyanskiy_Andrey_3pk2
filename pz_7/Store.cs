using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    class Store
    {
        public List<Product> AllPurchases { get; set; }

        public Store()
        {
            AllPurchases = new List<Product>();
        }

        public void SaveOrder(Product product, Client client)
        {
            double discount = product.GetDiscount(client.AllPurchases);
            double finalPrice = product.Price - discount;

            AllPurchases.Add(product);

            client.AllPurchases += finalPrice;
        }
    }
}
