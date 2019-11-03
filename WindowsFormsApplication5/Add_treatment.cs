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
    public partial class Add_treatment : Form
    {
        public Add_treatment()
        {
            InitializeComponent();
        }
        Operations.Op_Docs a = new Operations.Op_Docs();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_del_Click(object sender, EventArgs e)
        {
            a.FileToList("Patient.txt");
            a.Add_treatment(txtb_name.Text, textBox1.Text);
            a.SaveToFile_Pat("Patient.txt");
            textBox1.Clear();
            txtb_name.Clear();
        }
    }
}
