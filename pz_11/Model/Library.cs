using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11.Model
{
    public class Library
    {
        private List<Book> _books = new List<Book>();

        public IEnumerable<Book> Books => _books;

        public void AddBook(Book book)
        {
            _books.Add(book);
        }
    }
}
