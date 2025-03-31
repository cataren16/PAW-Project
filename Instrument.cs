using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Instrument : IValoare
    {
        private string simbol;
        List<Operatiune> operatiuni;

        public Instrument(string simbol, List<Operatiune> operatiuni)
        {
            this.simbol = simbol;
            this.operatiuni = operatiuni;
        }

        public string Simbol { get => simbol; set => simbol = value; }
        internal List<Operatiune> Operatiuni { get => operatiuni; set => operatiuni = value; }

        public double calculeazaValoare()
        {
            double valoare = 0;

            foreach(Operatiune o in operatiuni)
            {
                valoare += o.Cantitate * o.Pret * (int)o.Tip;
                
            }
            return valoare;
        }

        public void adaugaOperatiune(Operatiune o)
        {
            operatiuni.Add(o);
        }

        public override string ToString()
        {
          
            string rezultat =" ";
            

            return rezultat;
        }

        
    }
}
