using irokkönyvek_20240409.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.Services
{
    internal class AuthorService : IAuthorService
    {
        private readonly Context _c;

        public AuthorService(Context c)
        {
            _c = c;
        }

        bool IAuthorService.AddAuthor(Author a)
        {
            _c.Authors.Add(a);
            return true;
        }

        Author IAuthorService.GetAuthorById(int id)
        {

            return (Author)(from a in _c.Authors where a.Id == id select a);
        }

        List<Author> IAuthorService.GetAuthorList()
        {
            return (from a in _c.Authors.Include(i => i.Country) select a).ToList();
        }

        List<Author> IAuthorService.GetAuthorBooksList()
        {
            return (from a in _c.Authors.Include(i => i.Books) select a).ToList();
        }


    }
}
