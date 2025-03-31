using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        private Form1 _form1;
        

        
         List<Instrument> _portofoliu = new List<Instrument>();
        Instrument instrumentDeTrimis;


        public Form2(Form1 form1, List<Instrument> portofoliu)
        {
            InitializeComponent();
            _form1 = form1;
            _portofoliu = portofoliu;
            label4.Visible = false;
            label3.Visible = false;
            tbDivident.Visible = false;
            tbDobanda.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbComboInstrument.SelectedIndex == -1)
                errorProvider2.SetError(tbComboInstrument, "Selectati un instrument");
            else
             if (tbSimbol.Text == "")
                errorProvider2.SetError(tbSimbol, "Introduceti simbolul!");
            
            else
             if (tbDivident.Text == ""&&tbDobanda.Text=="")
                errorProvider2.SetError(button1, "Introduceti campul specializat!");
             else
            {
                errorProvider2.Clear();
                try
                {


                    string selectie = tbComboInstrument.SelectedItem.ToString();
                    string simbol = tbSimbol.Text;
                    if (selectie == "Actiune")
                    {


                        double procentDivident = Convert.ToDouble(tbDivident.Text);
                        instrumentDeTrimis = _portofoliu.FirstOrDefault(i => i.Simbol == simbol && ((Actiune)i).ProcentDividend == procentDivident);
                        if (instrumentDeTrimis == null)
                        {
                            List<Operatiune> _listaOperatiuni = new List<Operatiune>();
                            Instrument a = new Actiune(simbol, _listaOperatiuni, procentDivident);
                            _portofoliu.Add(a);
                            instrumentDeTrimis = _portofoliu.Last();

                        }
                    }
                    else

                    {
                        double dobanda = Convert.ToDouble(tbDobanda.Text);
                        instrumentDeTrimis = _portofoliu.FirstOrDefault(i => i.Simbol == simbol && ((Obligatiune)i).Dobanda == dobanda);
                        if (instrumentDeTrimis == null)
                        {
                            List<Operatiune> _listaOperatiuni = new List<Operatiune>();
                            Instrument o = new Obligatiune(dobanda, simbol, _listaOperatiuni);
                            _portofoliu.Add(o);
                            instrumentDeTrimis = _portofoliu.Last();
                        }

                    }

                    Form3 form3 = new Form3(this, instrumentDeTrimis);  
                    form3.Show();                   
                    this.Hide();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbDobanda.Clear();
                    tbDivident.Clear();
                    tbSimbol.Clear();
                }
                
            }


        }

        private void tbComboInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbComboInstrument.SelectedItem != null)
            {
                string selectie = tbComboInstrument.SelectedItem.ToString();

                if (selectie == "Actiune")
                {
                    
                    label4.Visible = false;
                    label3.Visible = true;
                    tbDobanda.Visible = false;
                    tbDivident.Visible = true;
                }
                else if (selectie == "Obligatiune")
                {
                    tbDivident.Visible = false;
                    tbDobanda.Visible = true;
                    label3.Visible = false;
                    label4.Visible = true;
                }

               

            }
            else
            {
                
                MessageBox.Show("Te rog să selectezi un tip de instrument.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            this.Close();        
            _form1.Show();                    


        }

        
    }
}