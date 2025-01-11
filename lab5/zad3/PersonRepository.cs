using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad3
{
    internal class PersonRepository : IPersonRepository
    {

        public PersonRepository() { }
        private List<Person> data = new() {
            new Person("Dominik","Pulnar",21, List<int>  = new List<int>{1,2,3} )
       
        };

    public List<Book> GetBooksByPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Book> LendBookToPerson(Book book)
        {
            throw new NotImplementedException();
        }

        public void Create(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person Get(long id)
        {
            throw new NotImplementedException();
        }
    }
}
