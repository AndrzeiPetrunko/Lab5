using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Osoba
    {
        public string imie;
        public string nazwisko;
        public int wiek;

        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }

        public override string? ToString()
        {
            return $"Imie: {this.imie}  Nazwisko: {this.nazwisko} wiek: {this.wiek.ToString()}";
        }
    }
}
