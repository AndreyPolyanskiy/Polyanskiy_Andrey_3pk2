using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_9
{

    // Класс, который будем адаптировать
    class Origin : IOrigin
    {
        public void OriginDouble(double d)
        {
            Console.WriteLine("Origin double: " + d);
        }

        public void OriginInt(int i)
        {
            Console.WriteLine("Origin int: " + i);
        }

        public void OriginChar(char c)
        {
            Console.WriteLine("Origin char: " + c);
        }
    }
}
