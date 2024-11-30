using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Osoba
    {
        string imie { get; set; }
        string nazwisko { get; set; }
        string pesel { get; set; }
        public void ustawImie(string imie)
        {
            this.imie = imie;
        }
        public void ustawNazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }
        public void ustawPesel(string pesel)
        {
            this.pesel = pesel;
        }
        public int pobierzWiek()
        {


            return 0;
        }
    }
}
