using pz_8;
using System;

// Интерфейс для создания объектов контактных данных
public interface IContactFactory//А еще при создании интерфейса у меня возникли ошибки, поэтому я решил оставить его сдесь
{
    Contact CreateContact();
}

class Program
{
    static void Main(string[] args)
    {
        // Создание телефонной книги
        PhoneBook phoneBook = new PhoneBook();

        // Добавление нового контакта физического лица
        phoneBook.AddContact(new PhysicalPersonContactFactory());

        // Добавление нового контакта компании
        phoneBook.AddContact(new CompanyContactFactory());

        // Отображение всех контактов в телефонной книге
        phoneBook.ShowContacts();
    }
}