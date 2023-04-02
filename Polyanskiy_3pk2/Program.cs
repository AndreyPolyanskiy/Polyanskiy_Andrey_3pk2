using Polyanskiy_3pk2;
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 задание:");
        _1_Задание.Method1();
        Console.WriteLine("\n2 задание:");//почему-то по нулям,хотя по гайдам из интернета, все сделал вроде как правильно, но не уверен
        _2_Задание.Method2();
        Console.WriteLine("\n3 задание:");
        _3_Задание.Method3();
        Console.WriteLine("\n4 задание:");
        _4_Задание.Method4();

        //ну какие выводы можно сделать по этому заданию, поиск элемента в хеш-таблице выполняется очень быстро, но и алгоритмы быстрой сортировки и бинарного поиска тоже эффективны

    }



}