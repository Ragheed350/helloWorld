using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win
{
    public partial class Graduation_Patient : Form
    {
        public Graduation_Patient()
        {
            InitializeComponent();
        }
        Operations.Op_Docs a = new Operations.Op_Docs();

        private void btt_del_Click(object sender, EventArgs e)
        {
            if (txtb_name.Text == "")
                MessageBox.Show("Please make sure all fields are full");
            a.Delete_pat(txtb_name.ToString());
            a.SaveToFile_Pat("Patient.txt");
            txtb_name.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
