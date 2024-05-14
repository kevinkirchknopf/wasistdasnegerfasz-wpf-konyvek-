using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}
