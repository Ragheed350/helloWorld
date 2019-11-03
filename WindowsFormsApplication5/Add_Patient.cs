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
    public partial class Add_Patient : Form
    {
        public Add_Patient()
        {
            InitializeComponent();
        }

        Operations.Op_Docs a = new Operations.Op_Docs();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label4.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="" || textBox3.Text=="" )
            {
                MessageBox.Show("please make sure all fields are full");
                 return;
            }
            if (radioButton1.Checked==true)
            {
                a.Add_Pat(new Patients(textBox2.Text, textBox3.Text, dateTimePicker1.Value, radioButton1.Text, textBox1.Text));
                a.SaveToFile_Pat("Patient.txt");
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                textBox1.Clear();
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked==true)
            {

                a.Add_Pat(new Patients(textBox2.Text, textBox3.Text, dateTimePicker1.Value, radioButton2.Text, textBox1.Text));
                a.SaveToFile_Pat("Patient.txt");
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                textBox1.Clear();
                radioButton1.Checked = false;
            }
        }

        private void Add_Patient_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
