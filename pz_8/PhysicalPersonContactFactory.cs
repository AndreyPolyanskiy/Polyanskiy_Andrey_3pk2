using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pz_8;

namespace pz_8
{
    // Класс фабрик для создания объектов контактных данных
    public class PhysicalPersonContactFactory : global::IContactFactory
    {
        public Contact CreateContact()
        {
            return new Contact();
        }
    }

    
}
