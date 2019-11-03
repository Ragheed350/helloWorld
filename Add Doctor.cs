using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operations.Op_Docs a = new Operations.Op_Docs();

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Make sure all fildes are full..");
                return;
            }

            if (rabu_reg.Checked == true)
            {

                a.Add_Docs(new Doctors_Clasess.Doctors(textBox2.Text, textBox3.Text, dateTimePicker1.Value, double.Parse(textBox5.Text)));
                a.SaveToFile("Doctor.txt");
            }
             if(rabu_tra.Checked==true)
            {
                a.Tra_Docs(new Doctors_Clasess.Trained_Doctor(
                    textBox2.Text, 
                    textBox3.Text, 
                    dateTimePicker1.Value,
                    Timer_start.Value, 
                    Timer_end.Value, 
                    double.Parse(textBox5.Text)));
                a.SaveToFile_Tra("Tra_Doc.txt");
            }
            if(rabu_ret.Checked==true)
            {
                a.Ret_Docs(new Doctors_Clasess.Retired_Doctor(textBox2.Text, textBox3.Text, dateTimePicker1.Value, double.Parse(textBox5.Text)));
                a.SaveToFile_Ret("Ret_Doc.txt");
            }
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            dateTimePicker1.ResetText();
        }

    
        private void rabu_reg_CheckedChanged(object sender, EventArgs e)
        {
            Timer_start.Visible = false;
            Timer_end.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            
            button1.Height = 43;
        }

        private void rabu_tra_CheckedChanged(object sender, EventArgs e)
        {
            Timer_start.Visible = true;
            Timer_end.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            button1.Height = 162;

        }

        private void rabu_ret_CheckedChanged(object sender, EventArgs e)
        {
            Timer_start.Visible = false;
            Timer_end.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            button1.Height = 43;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_Doctors f = new Delete_Doctors();
            f.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rabu_reg.Checked = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       


     
    }
}
