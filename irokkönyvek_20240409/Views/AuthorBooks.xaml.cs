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
    /// Interaction logic for AuthorBooks.xaml
    /// </summary>
    public partial class AuthorBooks : UserControl
    {
        private readonly AuthorLIstModel ALM;

        public AuthorBooks()
        {
            InitializeComponent();
            ALM = App.Current.Services.GetService<AuthorLIstModel>();
            dataGrid.DataContext = ALM.authorbooklist;
            

        }
    }
}
