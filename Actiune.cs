using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Actiune : Instrument
    {
        private double procentDividend;

        public Actiune(string simbol, List<Operatiune> operatiuni,double procentDividend) : base(simbol,operatiuni)
        {
            this.procentDividend = procentDividend;
        }

       
        public double ProcentDividend { get => procentDividend; set => procentDividend = value; }

        public override string ToString()
        {

            string rezultat = base.Simbol + "," + ProcentDividend + Environment.NewLine;
            foreach(Operatiune o in base.Operatiuni)
            {
                rezultat += o.ToString();
            }
            rezultat += Environment.NewLine;
            return rezultat;
        }
    }
}

