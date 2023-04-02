using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5
{
    class Human2 : IComparable<Human2>
    {
        public string Name { get; set; }
        public int Money { get; set; }
       

        public Human2(string name, int money)
        {
            Name = name;
            Money = money;
            
        }
        public int CompareTo(Human2? hum2)
        {
            if (hum2 is Human2 human2) return Name.CompareTo(human2.Name);
            else throw new ArgumentException("Некорректное значение параметра");

        }
    }
}
