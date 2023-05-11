using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_9
{

    // Класс, который будет использовать адаптированный класс
    class Client
    {
        private readonly IOrigin _origin;

        public Client(IOrigin origin)
        {
            _origin = origin;
        }

        public void ClientDouble(double d)
        {
            _origin.OriginDouble(d);
        }

        public void ClientInt(int i)
        {
            _origin.OriginInt(i * 2);
        }

        public void ClientChar(char c)
        {
            for (int i = 0; i < 5; i++)
            {
                _origin.OriginChar(c);
            }
        }
    }
}
