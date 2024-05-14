using irokkönyvek_20240409.Models;
using irokkönyvek_20240409.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.ViewModels
{
    class BookListViewModel
    {
        private readonly IBookService _service;
        
        public ObservableCollection<Book> booklist { get; set; }
        

        public BookListViewModel(IBookService service)
        {
            _service = service;
            booklist = new ObservableCollection<Book>(_service.GetAllBooks());
            

        }
    }
}
