using irokkönyvek_20240409.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace irokkönyvek_20240409.Views
{
    /// <summary>
    /// Interaction logic for BookListView.xaml
    /// </summary>
    public partial class BookListView : UserControl
    {
        private readonly BookListViewModel vm;

        public BookListView()
        {
            InitializeComponent();
            vm = App.Current.Services.GetService<BookListViewModel>();
            this.DataContext = vm.booklist;
            dataGrid.ItemsSource = vm.booklist;
        }
    }
}
