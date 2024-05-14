using irokkönyvek_20240409.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.Services
{
    internal class BookService : IBookService
    {
        private readonly Context _c;

        public BookService(Context c)
        {
            _c = c;
        }


        bool IBookService.AddBook(Book b)
        {
            _c.Books.Add(b);
            _c.SaveChanges();
            return true;
        }

        List<Book> IBookService.GetAllBooks()
        {
            return (from i in _c.Books.Include(i => i.Author)
                    select i).ToList();
        }

        Book IBookService.GetBookById(int id)
        {
            return (Book)from b in _c.Books where b.Id == id select b;
        }
    }
}
