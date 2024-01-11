using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab5
{
    internal class ListaOsob 
    {
        List<Osoba> listos;
        public ListaOsob()
        {
            listos = new List<Osoba>();
        }
        public void Loaddata(string plik)
        {
            /*StreamReader str = File.OpenText(plik); // otwarcie pliku
            string dane = "";
            while ((dane = str.ReadLine()) != null)
            {
                string[] pole = dane.Split(' ');
                Console.WriteLine(pole[0] + pole[1] + pole[2]);
                listos.Add(new Osoba(pole[0], pole[1], Int32.Parse(pole[2])));
            }
            str.Close();*/
            foreach (string line in File.ReadLines(plik))
            {
                string[] pole = line.Split(' ');
                /*Console.WriteLine(pole[0] + pole[1] + pole[2]);*/
                listos.Add(new Osoba(pole[0], pole[1], Int32.Parse(pole[2])));
            }
        }
        public void printData()
        {
            foreach (Osoba o in listos)
            {
                Console.WriteLine(o.ToString());
            }

        }
        public void SortByAge()
        {
            listos.Sort(delegate (Osoba x, Osoba y)
            {
                return x.wiek.CompareTo(y.wiek);
            });
        }
        public void SortBySurname()
        {
            listos.Sort(delegate (Osoba x, Osoba y)
            {
                return x.nazwisko.CompareTo(y.nazwisko);
            });
        }
        public Osoba FindOldestosoba()
        {
            SortByAge();
            return listos[listos.Count - 1];
        }
        public void DeletePerson(int poz)
        {
            listos.RemoveAt(poz);
        }
        public void EditPerson(int poz, string imie, string nazwisko, int wiek)
        {
            listos.ElementAt(poz).imie = imie;
            listos.ElementAt(poz).nazwisko = nazwisko;
            listos.ElementAt(poz).wiek = wiek;
        }
        public void SaveToJSON(string plik)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(listos);
            System.IO.File.WriteAllText(plik, json);
        }
    }
}
