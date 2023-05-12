using pz_11.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace pz_11.ViewModel
{
    public class LibraryViewModel : INotifyPropertyChanged
    {
        private string _title;
        private string _author;
        private string _year;
        private ObservableCollection<Book> _books = new ObservableCollection<Book>();

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (_author != value)
                {
                    _author = value;
                    OnPropertyChanged("Author");
                }
            }
        }

        public string Year
        {
            get { return _year; }
            set
            {
                if (_year != value)
                {
                    _year = value;
                    OnPropertyChanged("Year");
                }
            }
        }

        public ObservableCollection<Book> Books
        {
            get { return _books; }
            set
            {
                if (_books != value)
                {
                    _books = value;
                    OnPropertyChanged("Books");
                }
            }
        }

        public ICommand SaveCommand { get; set; }

        public LibraryViewModel()
        {
            SaveCommand = new RelayCommand(SaveBook);
        }

        private void SaveBook()
        {
            var book = new Book
            {
                Title = Title,
                Author = Author,
                Year = Convert.ToInt32(Year)
            };

            Books.Add(book);

            Title = "";
            Author = "";
            Year = "";
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}