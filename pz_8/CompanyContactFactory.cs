using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    // Класс фабрик для создания объектов контактных данных
    public class CompanyContactFactory : global::IContactFactory
    {
        public Contact CreateContact()
        {
            return new Contact();
        }
    }
}
