using pz_9;
using System;

// Пример использования адаптированного класса
class Program
{
    static void Main(string[] args)
    {
        Origin origin = new Origin();
        Client client = new Client(origin);
        client.ClientDouble(3.14);
        client.ClientInt(42);
        client.ClientChar('A');
    }
}