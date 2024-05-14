using irokkönyvek_20240409.Models;
using irokkönyvek_20240409.ViewModels;
using irokkönyvek_20240409.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace irokkönyvek_20240409
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AuthorList authorList;
        BookListView bookList;
        CountryList countryList;
        AuthorBooks authorsBooks;
        public MainWindow()
        {
            InitializeComponent();
            Context c = new Context();
            c.Database.EnsureCreated();
            authorList = new AuthorList();
            bookList = new BookListView();
            countryList = new CountryList();
            authorsBooks = new AuthorBooks();
            c.SaveChanges();
        }

        private void btauthor_Click(object sender, RoutedEventArgs e)
        {
            contentcontrol.Content = authorList.Content;
        }

        private void btbook_Click(object sender, RoutedEventArgs e)
        {
            contentcontrol.Content = bookList.Content;
        }

        private void btcountry_Click(object sender, RoutedEventArgs e)
        {
            contentcontrol.Content = countryList.Content;
        }

        private void btauthorbooks_Click(object sender, RoutedEventArgs e)
        {
            contentcontrol.Content = authorsBooks.Content;
        }
    }
}