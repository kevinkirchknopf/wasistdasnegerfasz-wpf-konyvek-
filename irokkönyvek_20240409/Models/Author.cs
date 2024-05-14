using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }

        public ICollection<Book> Books { get; set; }

        public Country? Country { get; set; }
        public int? CountryId { get; set; }

    }
}
