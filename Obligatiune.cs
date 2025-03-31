using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Obligatiune : Instrument
    {
        private double dobanda;

        public Obligatiune(double dobanda,string simbol, List<Operatiune> operatiuni) : base(simbol, operatiuni)
        {
            this.dobanda = dobanda;
        }

        public double Dobanda { get => dobanda; set => dobanda = value; }

        public override string ToString()
        {

            string rezultat = base.Simbol + ", " + Dobanda+ Environment.NewLine;
            foreach (Operatiune o in base.Operatiuni)
            {
                rezultat += o.ToString();
            }
            rezultat += Environment.NewLine;
            return rezultat;
        }
    }
}
