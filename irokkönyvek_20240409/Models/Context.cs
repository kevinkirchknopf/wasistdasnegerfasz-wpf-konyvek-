using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.Models
{
    public class Context : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Country> Countries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConnectionString
            string c = "server = localhost; userid = root; password =; database = Könyvtar";

            //OptionBulider: ConnectionString + Szerver verzió (manuálisan, vagy Autodetect)
            optionsBuilder.UseMySql(c,ServerVersion.AutoDetect(c));

        }
    }
}
