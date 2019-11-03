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
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }
        private void formInPanel(object formi)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formi as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }
                

        private void button1_Click(object sender, EventArgs e)
        {
            formInPanel(new Form1());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formInPanel(new Graduation_Patient());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formInPanel(new Delete_Doctors());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formInPanel(new Add_Patient());
        }

        private void but_trea_Click(object sender, EventArgs e)
        {
            formInPanel(new Add_treatment());
        }

        private void butEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            formInPanel(new Show_patient());
        }
    }
}
