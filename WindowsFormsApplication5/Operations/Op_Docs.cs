using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Win.Doctors_Clasess;

namespace Win.Operations
{
    public class Op_Docs
    {
        public List<Doctors> Docs_list = new List<Doctors>();
        public List<Doctors> Ret_list = new List<Doctors>();
        public List<Trained_Doctor> Tra_list = new List<Trained_Doctor>();
        public List<Patients> Pat_list = new List<Patients>();


        public void FileToList(string file_path)
        {
            StreamReader sr = new StreamReader(file_path);
            string str = sr.ReadLine();
            if (file_path == "Doctor.txt" || file_path == "Ret_Doc.txt")
            {
                while (str != null)
                {
                    string[] arr = str.Split(',');
                    Doctors d = new Doctors();
                    d.doctor_Id = int.Parse(arr[0]);
                    d.doctor_name = arr[1];
                    d.doctor_birth =DateTime.Parse(arr[2]);
                    d.doctor_location = arr[3];
                    d.doctor_sal = double.Parse(arr[4]);

                    Add_Docs(d);

                    str = sr.ReadLine();
                }
                sr.Close();
            }

            if (file_path == "Tra_Doc.txt")
            {
                while (str != null)
                {
                    string[] arr = str.Split(',');
                    Trained_Doctor d = new Trained_Doctor();
                    d.doctor_Id = int.Parse(arr[0]);
                    d.doctor_name = arr[1];
                    d.doctor_birth = DateTime.Parse(arr[2]);
                    d.doctor_location = arr[3];
                    d.doctor_sal = double.Parse(arr[4]);
                    d.start = DateTime.Parse( arr[5]);
                    d.end = DateTime.Parse(arr[6]);

                    Tra_Docs(d);

                    str = sr.ReadLine();
                }
                sr.Close();
            }
            if (file_path == "Patient.txt")
            {
                while (str != null)
                {
                    string[] arr = str.Split(',');
                    Patients d = new Patients();
                    d.patient_id = int.Parse(arr[0]);
                    d.patient_name = arr[1];
                    d.patient_location = arr[2];
                    d.patient_birth = DateTime.Parse(arr[3]);
                    d.patient_stauts = arr[4];
                    d.patient_treatment = arr[5];

                    Add_Pat(d);

                    str = sr.ReadLine();
                }
                sr.Close();
            }
            sr.Close();

        }


        public void Add_Docs(Doctors New_doc)
        {
            Docs_list.Add(New_doc);
        }
        public void Add_Pat(Patients New_pat)
        {
            Pat_list.Add(New_pat);
        }
        public void Tra_Docs(Trained_Doctor New_doc)
        {
            Tra_list.Add(New_doc);
        }
        public void Ret_Docs(Doctors New_doc)
        {
            Ret_list.Add(New_doc);
        }

        public void SaveToFile(string s)
        {
            StreamWriter sw = new StreamWriter(s, false);

            using (sw)
            {
                foreach (Doctors c in Docs_list)
                {
                    sw.WriteLine(c.doctor_Id + "," + c.doctor_name + "," + c.doctor_birth + "," + c.doctor_location + "," + c.doctor_sal);

                }
                System.Windows.Forms.MessageBox.Show("Saved to file");
                sw.Close();
            }


        }
        public void SaveToFile_Tra(string s)
        {
            StreamWriter sw = new StreamWriter(s, true);

            using (sw)
            {
                foreach (Trained_Doctor c in Tra_list)
                {
                    sw.WriteLine(c.doctor_Id + "," + c.doctor_name + "," + c.doctor_birth + "," + c.doctor_location + "," + c.doctor_sal + "," + c.start + "," + c.end);

                }
                System.Windows.Forms.MessageBox.Show("Doctors Saved..");
                sw.Close();
            }


        }
        public void SaveToFile_Ret(string s)
        {
            StreamWriter sw = new StreamWriter(s, false);

            using (sw)
            {
                foreach (Doctors c in Ret_list)
                {
                    sw.WriteLine(c.doctor_Id + "," + c.doctor_name + "," + c.doctor_birth + "," + c.doctor_location + "," + c.doctor_sal);

                }
                System.Windows.Forms.MessageBox.Show("Doctors Saved..");
                sw.Close();
            }


        }

        public void SaveToFile_Pat(string s)
        {
            StreamWriter sw = new StreamWriter(s, false);

            using (sw)
            {
                foreach (Patients c in Pat_list)
                {
                    sw.WriteLine(c.patient_id + "," + c.patient_name + "," + c.patient_location + "," + c.patient_birth + "," + c.patient_stauts + "," + c.patient_treatment);

                }
                System.Windows.Forms.MessageBox.Show("Patient Saved..");
                sw.Close();
            }
        }

        public void Delete_doc(string c, string file_path)
        {
            StreamReader f = new StreamReader(file_path, true);

            for (int i = 0; i < Docs_list.Count; i++)
            {
                if (c.CompareTo(Docs_list[i].doctor_name) == 0)
                {
                    Docs_list.Remove(Docs_list[i]);
                    f.Close();
                    System.Windows.Forms.MessageBox.Show("Deleted");
                    break;
                }
            }
            if (Docs_list.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("File is empty");
                f.Close();
                return;
            }
            
                System.Windows.Forms.MessageBox.Show("No doctor found");

            f.Close();

        }

        public void Delete_pat(string c)
        {
            StreamReader f = new StreamReader("Patient.txt", true);

            for (int i = 0; i < Pat_list.Count; i++)
            {
                if (c == Pat_list[i].patient_name)
                {
                    Pat_list.Remove(Pat_list[i]);
                    System.Windows.Forms.MessageBox.Show("Deleted");
                    f.Close();
                    break;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No patient found");

                }
            }
            if (Pat_list.Count == 0)
                System.Windows.Forms.MessageBox.Show("File is empty");

            f.Close();


        }
        public void Add_treatment(string c, string new_treat)
        {
            int i = 0;
            for ( ;i <Pat_list.Count; i++)
            {
                while (c == Pat_list[i].patient_name)
                {
                    Pat_list[i].patient_treatment += " - "+new_treat;

                    System.Windows.Forms.MessageBox.Show("Treatment added");
                    break;
                }                         
            }
            if(Pat_list.Count==0)
            System.Windows.Forms.MessageBox.Show("File is empty");
            System.Windows.Forms.MessageBox.Show("No patient found");


        }

        public List<Patients> h_list = new List<Patients>();
        public void show(string s)
        {
            for (int i = 0; i < Pat_list.Count; i++)
            {
                if (s==Pat_list[i].patient_stauts)
                {
                    h_list.Add(Pat_list[i]);
                    
                }
            }
        }
    }
}

