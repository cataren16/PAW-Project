using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Operatiune
    {
       
        public enum TipOperatiune  
        {
            CUMPARARE=-1,
            VANZARE=1
        }

        private TipOperatiune tip;
        private int cantitate;
        private double pret;
        private DateTime dataEfectuare;

        public Operatiune(TipOperatiune tip, int cantitate, double pret, DateTime dataEfectuare)
        {
            this.tip = tip;
            this.cantitate = cantitate;
            this.pret = pret;
            this.dataEfectuare = dataEfectuare;
        }

        internal TipOperatiune Tip { get => tip; set => tip = value; }
        public int Cantitate { get => cantitate; set => cantitate = value; }
        public double Pret { get => pret; set => pret = value; }
        public DateTime DataEfectuare { get => dataEfectuare; set => dataEfectuare = value; }

        public override string ToString()
        {

            string rezultat = tip + ", " + cantitate + ", " + pret + ", " + dataEfectuare;
            rezultat += Environment.NewLine;

            return rezultat;
        }
    }
}
