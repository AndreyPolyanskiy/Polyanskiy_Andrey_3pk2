using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    // Класс телефонной книги
    public class PhoneBook
    {
        private List<Contact> contacts;

        public PhoneBook()
        {
            contacts = new List<Contact>();
        }

        // Добавление нового контакта через фабрику
        public void AddContact(global::IContactFactory factory)
        {
            Contact contact = factory.CreateContact();

            Console.Write("Введите имя: ");
            contact.Name = Console.ReadLine();

            Console.Write("Введите номер телефона: ");
            contact.Phone = Console.ReadLine();

            contacts.Add(contact);
        }

        // Отображение всех контактов в телефонной книге
        public void ShowContacts()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
