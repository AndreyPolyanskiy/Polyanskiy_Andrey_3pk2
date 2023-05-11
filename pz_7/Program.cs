using pz_7;
using System;
using System.Collections.Generic;

namespace pz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client { Name = "Андрей" };
            Client client2 = new Client { Name = "Ваня" };
            Store store = new Store();
            Milk milk = new Milk();
            Bread bread = new Bread();
            Cheese cheese = new Cheese();
            store.SaveOrder(milk, client1);
            store.SaveOrder(bread, client1);
            store.SaveOrder(milk, client2);
            store.SaveOrder(bread, client2);
            store.SaveOrder(cheese, client2);
            Console.WriteLine("Общий объем закупок {0}: {1}", client1.Name, client1.AllPurchases);
            Console.WriteLine("Общий объем закупок {0}: {1}", client2.Name, client2.AllPurchases);
            Console.WriteLine();
            Console.WriteLine("Все покупки:");
            foreach (Product product in store.AllPurchases)
            {
                Console.WriteLine("{0} - {1}", product.Name, product.Price);
            }
            Console.ReadKey();
            //наследование классов и переопределение методов позволяет уменьшить количество дублирующегося кода,
            //повысить его читаемость и упростить сопровождение приложения.
            //Также это позволяет удобно расширять функциональность приложения,
            //добавляя новые классы или переопределяя методы.
            //Однако, необходимо учитывать, что чрезмерное использование наследования может привести к усложнению кода и ухудшению его читаемости,
            //поэтому нужно находить баланс между простотой и гибкостью приложения.
        }
    }
}