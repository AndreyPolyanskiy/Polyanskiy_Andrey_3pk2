using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    // Класс контактных данных
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}, Телефон: {Phone}";
        }
    }
}
