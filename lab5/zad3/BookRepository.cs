using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab5.zad3
{
    internal class BookRepository : IBookRepository
    {
        public BookRepository() { }
        private List<Book> data = new() {
            new Book(1,  "Potop",
               "Sienkiewicz",
                DateTime.Now)
        };

        public void Create(Book entity)
        {
            entity.Id = data.Count + 1;
            data.Add(entity);
        }

        public void Delete(int id)
        {
            data.RemoveAll(x => x.Id == id);
        }

        public Book Get(int id)
        {
            return data.Find(x => x.Id == id);
        }

        public List<Book> GetAll()
        {
            return data;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return data.Where(x => x.author == author).ToList();
        }

        public List<Book> GetBooksByPublishYear(int year)
        {
            return data.Where(x => x.releaseDate.Year == year).ToList();
        }

        public void Update(Book entity)
        {
            var index = data.FindIndex(x => x.Id == entity.Id);
            if (index > -1)
                data[index] = entity;
        }
    }
}
