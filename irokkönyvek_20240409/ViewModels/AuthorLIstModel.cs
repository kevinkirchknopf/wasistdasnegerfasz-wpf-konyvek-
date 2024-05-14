using irokkönyvek_20240409.Models;
using irokkönyvek_20240409.Services;
using irokkönyvek_20240409.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace irokkönyvek_20240409.ViewModels
{
    internal class AuthorLIstModel
    {
        private readonly IAuthorService _ias;
        public ObservableCollection<Author> AuthorCollection { get; set; }
        public ObservableCollection<Author> authorbooklist { get; set; }

        public AuthorLIstModel(IAuthorService IAS)
        {
            _ias = IAS;
            AuthorCollection = new ObservableCollection<Author>(_ias.GetAuthorList());
            authorbooklist = new ObservableCollection<Author>(_ias.GetAuthorBooksList());



        }
        

    }
}
