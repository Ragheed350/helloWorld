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
    public partial class Delete_Doctors : Form
    {
        public Delete_Doctors()
        {
            InitializeComponent();
        }

        Operations.Op_Docs a = new Operations.Op_Docs();
        
        private void Delete_Doctors_Load(object sender, EventArgs e)
        {
            rabu_reg.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rabu_reg.Checked == true)
            {
                a.FileToList("Doctor.txt");
                a.Delete_doc(txtb_name.Text,"Doctor.txt");
                a.SaveToFile("Doctor.txt");
            }
            if (rabu_ret.Checked==true)
            {
                a.FileToList("Ret_Doc.txt");
                a.Delete_doc(txtb_name.Text, "Ret_Doc.txt");
                a.SaveToFile_Ret("Ret_Doc.txt"); 
            }
            if (rabu_tra.Checked==true)
            {
                a.FileToList("Tra_Doc.txt");
                a.Delete_doc(txtb_name.Text, "Tra_Doc.txt");
                a.SaveToFile_Tra("Tra_Doc.txt");
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
