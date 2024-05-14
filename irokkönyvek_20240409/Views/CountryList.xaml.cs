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
    /// Interaction logic for CountryList.xaml
    /// </summary>
    public partial class CountryList : UserControl
    {
        private readonly CountryListViewModel vm;

        public CountryList()
        {
            InitializeComponent();
            vm = App.Current.Services.GetService<CountryListViewModel>();
            this.DataContext = vm.countrylist;
            dataGrid.ItemsSource = vm.countrylist;
        }
    }
}
