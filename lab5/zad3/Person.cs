using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad3
{
    public class Person: IData,IEntity<long>
    {
        public long Id { get; set; }
        public DateTime releaseDate { get; set; }

        string Imie;
        string Nazwisko;
        int Wiek;
        List<int> books;

        public Person (string imie, string nazwisko, int wiek, List<int> books)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            this.books = books;
        }

     
    }
}
