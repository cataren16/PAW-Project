using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<User> Users = new List<User>();

        List<Instrument> portofoliu;
        User existaUser=null;

        public Form1()
        {
            InitializeComponent();
            btCreazaPortofoliu.Visible = false;
            btAdaugaInstrument.Visible = false;
           
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            else
             if (tbPrenume.Text == "")
                errorProvider1.SetError(tbPrenume, "Introduceti prenumele!");
            else
            {
                errorProvider1.Clear();
                try
                {

                    string nume = tbNume.Text;
                    string prenume = tbPrenume.Text;
                   
                    existaUser = Users.FirstOrDefault(i => i.Nume1 == nume && i.Prenume1 == prenume);
                    if (existaUser == null)
                    {
                        portofoliu = new List<Instrument>();
                        User s = new User(nume, prenume, portofoliu);
                        Users.Add(s);
                        existaUser = Users.Last();
                        btCreazaPortofoliu.Visible = true;
                        btAdaugaInstrument.Visible = false;
                        label3.Text = "Mult succes in crearea portofoliului tau," + prenume + "!";
                        label3.Visible = true;
                    }
                    else
                    {
                        btAdaugaInstrument.Visible = true;
                        btCreazaPortofoliu.Visible = false;
                        label3.Text = "Bine ai revenit, " + prenume + "!";
                        label3.Visible = true;
                    }

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNume.Clear();
                    tbPrenume.Clear();
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this,existaUser.Portofoliu1);  
            form2.Show();                   
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Users.Count > 0)
            {
                Form4 frm = new Form4(Users); 
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Acceseaza mai intai portofoliul personal - Verifica Portofoliu!");
            }
            
        }

        

        private void btCreazaPortofoliu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, existaUser.Portofoliu1);  
            form2.Show();                  
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (existaUser != null)
            { tbValoare.Text = Convert.ToString(existaUser.calculeazaValoare()); }
            else
            {
                tbValoare.Text = "0";
            }
            
        }
    }
}


