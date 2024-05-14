using irokkönyvek_20240409.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.Services
{
    internal interface IBookService
    {
        public List<Book> GetAllBooks();

        public Book GetBookById(int id);

        public bool AddBook(Book b);






    }
}
