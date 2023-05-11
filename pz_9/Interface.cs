using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_9
{
    // Определяем интерфейс для адаптируемого класса
    interface IOrigin
    {
        void OriginDouble(double d);
        void OriginInt(int i);
        void OriginChar(char c);
    }
}
