using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form3 : Form
    {
        private Form2 _form2;
        private Instrument _instrument;
        public Form3(Form2 form2, Instrument instrument)
        {
            InitializeComponent();
            _form2 = form2;
            _instrument = instrument;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            _form2.Show();
        }

        private void tbAdaugaOperatiune_Click(object sender, EventArgs e)
        {

            if (!rbCumparare.Checked && !rbVanzare.Checked)
                errorProvider3.SetError(rbCumparare, "Selectati un tip de tranzactie");
            else
             if (tbCantitate.Text == "")
                errorProvider3.SetError(tbCantitate, "Introduceti cantitatea!");
            else
            if (tbPret.Text == "")
                errorProvider3.SetError(tbPret, "Introduceti pretul!");
            else
            if (dbData.Text == "")
                errorProvider3.SetError(dbData, "Introduceti data tranzactiei!");

            else
            {
                errorProvider3.Clear();
                try
                {



                    double pret = Convert.ToDouble(tbPret.Text);
                    int cantitate = Convert.ToInt32(tbCantitate.Text);
                    DateTime data = dbData.Value;

                    if (rbVanzare.Checked)
                    {
                        Operatiune o = new Operatiune(Operatiune.TipOperatiune.VANZARE, cantitate, pret, data);
                        _instrument.adaugaOperatiune(o);
                    }
                    else
                    {
                        Operatiune o = new Operatiune(Operatiune.TipOperatiune.CUMPARARE, cantitate, pret, data);
                        _instrument.adaugaOperatiune(o);
                    }






                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    label4.Text = "Operatiune inregistrata cu succes.";
                    tbCantitate.Clear();
                    tbPret.Clear();
                    

                }


            }


        }


        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbCantitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9'
               || 
                   e.KeyChar == ',' ||     
                   e.KeyChar == '.')
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}

