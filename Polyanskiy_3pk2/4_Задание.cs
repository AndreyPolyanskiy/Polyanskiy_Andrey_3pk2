using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyanskiy_3pk2
{
    internal class _4_Задание
    {
        public static void Method4()
        {
            Hashtable hashtable = new Hashtable(5000); // создаем хеш-таблицу размерностью 5000 символов
            Random rand = new Random();
            for (int i = 0; i < 5000; i++)
            {
                hashtable.Add(i, rand.Next(0, 1000)); // добавляем в хеш-таблицу случайное значение для каждого ключа
            }

            Console.WriteLine("Введите номер элемента для поиска: ");
            int index = Convert.ToInt32(Console.ReadLine());

            DateTime start = DateTime.Now; // запускаем секундомер
            if (hashtable.ContainsKey(index))
            {
                Console.WriteLine($"Элемент найден: {hashtable[index]}");
            }
            else
            {
                Console.WriteLine("Элемент не найден");
            }
            TimeSpan duration = DateTime.Now - start; // останавливаем секундомер и вычисляем время выполнения
            Console.WriteLine($"Время выполнения поиска: {duration.TotalMilliseconds} мс");

            Console.ReadKey();
        }
    }
}
