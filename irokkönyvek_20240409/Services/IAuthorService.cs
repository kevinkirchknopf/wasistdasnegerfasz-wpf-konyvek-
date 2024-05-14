using irokkönyvek_20240409.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irokkönyvek_20240409.Services
{
    internal interface IAuthorService
    {
        public Author GetAuthorById(int id);

        public List<Author> GetAuthorList();

        public bool AddAuthor(Author a);

        public List<Author> GetAuthorBooksList();

    }
}
