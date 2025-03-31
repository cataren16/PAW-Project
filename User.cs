using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class User : IValoare
    {
        
        private string Nume;
        private string Prenume;
        private List<Instrument> Portofoliu;

        public User(string nume, string prenume, List<Instrument> portofoliu)
        {
           
            Nume = nume;
            Prenume = prenume;
            Portofoliu = portofoliu;
        }

        
        public string Nume1 { get => Nume; set => Nume = value; }
        public string Prenume1 { get => Prenume; set => Prenume = value; }
        internal List<Instrument> Portofoliu1 { get => Portofoliu; set => Portofoliu = value; }

        public static User operator+(User u, Actiune a)
            {
            u.Portofoliu.Add(a);
            return u;
            }
        public override string ToString()
        {
            string rezultat = Nume + " " + Prenume + Environment.NewLine +
                "Portofoliul:" + Environment.NewLine;
            foreach(var instrument in Portofoliu)
            {
                rezultat += instrument.ToString();
            }
           
            return rezultat;
        }

        public double calculeazaValoare()
        {
            double valoare = 0;
            foreach(Instrument instrument in Portofoliu)
            {
                valoare += instrument.calculeazaValoare();
            }

            return valoare;

        }



    }
}
        
