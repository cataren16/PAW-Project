using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        List<User> _Users = new List<User>();
        public Form4(List<User> Users)
        {
            InitializeComponent();
            
            _Users = Users;
            foreach (User user in _Users)
            {
                tbAfisare.Text = user.ToString() + Environment.NewLine;
            }
        }

        

        private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, _Users);
            tbAfisare.Clear();
            fs.Close();

        }

        private void deserializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<User> Users = (List<User>)bf.Deserialize(fs);
            foreach (User u in Users)
                tbAfisare.Text += u.ToString() + Environment.NewLine;
            fs.Close();
        }
    }
}
