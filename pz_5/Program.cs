using pz_5;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nICloneable\n ");
        //ICloneable

        //Ориг
        Console.WriteLine("\nОригинальный человек\n ");
        var original = new Human("Андрей", 19);
        Console.WriteLine(original);
        //Делаем с тем-же именем, но меняем возраст
        Console.WriteLine("\nВведите возраст\n");
        var clone = (Human)original.Clone();
        clone.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nЕго копия\n ");
        
        
        
        Console.WriteLine("\n" + clone);

        Console.WriteLine("\nIComparable\n ");
        //IComparable
        var Human1 = new Human2("Андрея", 0);
        var Human2 = new Human2("Вани Вани", 5000);
        

        Human2[] works_name = { Human1, Human2};
        Array.Sort(works_name);
        foreach (Human2 human2 in works_name)
        {
            Console.WriteLine($"У человека {human2.Name} на карточке: {human2.Money}");

        }


        Console.ReadLine();
    }
}