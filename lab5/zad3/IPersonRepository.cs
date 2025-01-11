using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad3
{
    internal interface IPersonRepository :IBaseRepository<Person,long>
    {
        List<Book> GetBooksByPerson(Person person);
        List<Book> LendBookToPerson(Book book);

    }
}
