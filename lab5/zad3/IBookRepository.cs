using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad3
{
    public interface IBookRepository : IBaseRepository<Book,int>
    {
        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByPublishYear(int year);
    }
}
