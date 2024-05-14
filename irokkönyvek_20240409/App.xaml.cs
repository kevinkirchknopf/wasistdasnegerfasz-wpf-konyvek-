using irokkönyvek_20240409.Models;
using irokkönyvek_20240409.Services;
using irokkönyvek_20240409.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace irokkönyvek_20240409
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ///<summary>
            ///A PLUSZ SZOLGÁLTATÁSOK HOZZÁADÁS
            ///</summary>A
            Services = ConfigureServices();

            this.InitializeComponent();
        }


        //EZEN A METÓDUSON KERESZTÜL LEHET ELKÉRNI A VIEWMODEL-leket
        public new static App Current => (App)Application.Current;


        public IServiceProvider Services { get; }



        private static IServiceProvider ConfigureServices()
        {
            ///<summary>
            ///A SZOLGÁLTATÁSOK-KÉSZLET PÉLDÁNYOSÍTÁSA
            ///SAJÁT SZOLGÁTATÁS HOZZÁADÁSA
            ///A BŐVÍTETT KÉSZLET VISSZAADÁSA
            /// </summary>

            var services = new ServiceCollection();

            //HA VALAMELYIK KONSTRUKTOR IDataService PÉLDÁNYT KÉR, AKKOR EGY DataService PÉLDÁNYT AD AZ "APP"
            services.AddSingleton<IAuthorService, AuthorService>();
            services.AddSingleton<IBookService, BookService>();
            services.AddSingleton<ICountryService, CountryService>();



            //HA VALAKI AZ APPTOL ELKÉR EGY LISTMODELT
            services.AddTransient<AuthorLIstModel>();
            services.AddTransient<BookListViewModel>();
            services.AddTransient<CountryListViewModel>();


            //HA VALAKI AZ APP-tól KÉR EGY UserViewModel PÉLDÁNYT AKKOR INNÉT AD EGYET!
            services.AddDbContext<Context>();


            return services.BuildServiceProvider();
        }

    }
}

