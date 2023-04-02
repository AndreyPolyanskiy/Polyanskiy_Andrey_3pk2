using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5
{
    internal class Human : ICloneable
    {
        private string name;
        private int age;
        
        

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
           
            
        }


        public string Name
        {

            get { return name; }
            set
            {
                if (value != null)
                    name = value;
                else Console.WriteLine("Неверные данные");
            }

        }
        
        public int Age
        {
            get { return age; }
            set
            {
                if (value != null)
                    age = value;
                else Console.WriteLine("Неверные данные");
            }
        }

        public override string ToString()
        {
            return new string($"Имя: {Name}\nВозвраст: {Age}");
        }
        public object Clone() => new Human(name, age);
    }
}
