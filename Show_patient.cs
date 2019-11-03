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
    public partial class Show_patient : Form
    {
        public Show_patient()
        {
            InitializeComponent();
        }
        Operations.Op_Docs a = new Operations.Op_Docs();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Show_patient_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        






       //     string[] textData = File.ReadAllLines("Patient.txt");
       //     string[] headers = textData[0].Split(',');

       //     //Create and populate DataTable
       //     DataTable dataTable1 = new DataTable();
       ////     foreach (string header in headers)
       ////         dataTable1.Columns.Add("Name",typeof(string));
       //     for (int i = 0; i <= textData.Length; i++)
       //         dataTable1.Rows.Add(textData[i].Split(','));

       //     //Set the DataSource of DataGridView to the DataTable
       //     dataGridView1.DataSource = dataTable1;


           // OpenFileDialog ofd = new OpenFileDialog();
            //ofd.FileName = "Patient.txt";
            //FileStream fs = File.OpenRead(ofd.FileName);
   

          //  a.FileToList("Patient.txt");
          //  DataTable dt = new DataTable();
          ////  dt.Columns.Add("ID", typeof(int));
          //  for (int i = 0; i < a.Pat_list.Count; i++)
          //  {
          //      dt.Rows.Add(a.Pat_list[i].patient_id,
          //               a.Pat_list[i].patient_name, a.Pat_list[i].patient_location, 
          //               a.Pat_list[i].patient_birth,
          //               a.Pat_list[i].patient_stauts, a.Pat_list[i].patient_treatment);
          //  }
          //  dataGridView1.DataSource = dt;
        }

       


















           // StreamReader st = new StreamReader("Patient.txt");
            
           // string line = st.ReadLine();
           // int j = 0;
           // while (line != null)
           // {                
           //     string[] columns = line.Split(',');
           //     for (int i = 0; i < columns.Length; i++)
           //     {
           //          dt.Rows.Add(columns[j]);
           //         //  var index = dataGridView1.Rows.Add();
           //     }
           //     dataGridView1.DataSource = dt;
           //     j++;
           // }
               
           //st.Close();

            
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = null;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (radioButton1.Checked==true)
            {
                a.FileToList("Patient.txt");
                a.show(radioButton1.Text);
                a.FileToList("Patient.txt");

                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Patient Name", typeof(String));
                dt.Columns.Add("Address", typeof(String));
                dt.Columns.Add("Birthday", typeof(String));
                dt.Columns.Add("Patient Status", typeof(String));
                dt.Columns.Add("Treatment", typeof(String));

                for (int i = 0; i < a.h_list.Count; i++)
                {
                    dt.Rows.Add(a.h_list[i].patient_id,
                        a.h_list[i].patient_name,
                        a.h_list[i].patient_location,
                        a.h_list[i].patient_birth,
                        a.h_list[i].patient_stauts,
                        a.h_list[i].patient_treatment);
                }
                dataGridView1.DataSource = dt;
                
            }
            if (radioButton2.Checked==true)
            {
                   a.FileToList("Patient.txt");
                a.show(radioButton2.Text);
                a.FileToList("Patient.txt");

                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Patient Name", typeof(String));
                dt.Columns.Add("Address", typeof(String));
                dt.Columns.Add("Birthday", typeof(String));
                dt.Columns.Add("Patient Status", typeof(String));
                dt.Columns.Add("Treatment", typeof(String));

                for (int i = 0; i < a.h_list.Count; i++)
                {
                    dt.Rows.Add(a.h_list[i].patient_id,
                        a.h_list[i].patient_name,
                        a.h_list[i].patient_location,
                        a.h_list[i].patient_birth,
                        a.h_list[i].patient_stauts,
                        a.h_list[i].patient_treatment);
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void btt_del_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            //a.h_list = null;
            
            a.FileToList("Patient.txt");
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Patient Name", typeof(String));
            dt.Columns.Add("Address", typeof(String));
            dt.Columns.Add("Birthday", typeof(String));
            dt.Columns.Add("Patient Status", typeof(String));
            dt.Columns.Add("Treatment", typeof(String));

            for (int i = 0; i < a.Pat_list.Count; i++)
            {
                dt.Rows.Add(a.Pat_list[i].patient_id,
                    a.Pat_list[i].patient_name,
                    a.Pat_list[i].patient_location,
                    a.Pat_list[i].patient_birth,
                    a.Pat_list[i].patient_stauts,
                    a.Pat_list[i].patient_treatment);
            }
             dataGridView1.DataSource = dt;
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            a.h_list = null;
        }
    }
}
