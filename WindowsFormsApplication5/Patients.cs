using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Win
{
   public class Patients
    {
        public int patient_id;
        public string patient_name;
        public string patient_location;
        public DateTime patient_birth;
        public string patient_stauts;
        public string patient_treatment;

        public Patients() { }
        public Patients(string name,string location,DateTime birth,string status, string treat)
        {
            this.patient_id = Au_id() + 1;
            this.patient_name = name;
            this.patient_location =location;
            this.patient_birth = birth;
            this.patient_stauts = status;
            this.patient_treatment = treat;
        }
        int Au_id()
        {
            int Max = 0;
            StreamReader sr = new StreamReader("Patient.txt");
            List<int> id = new List<int>();
            string link;
            link = sr.ReadLine();
            using (sr)
            {
                while (link != null)
                {
                    string[] s = link.Split(',');
                    id.Add(int.Parse(s[0]));
                    link = sr.ReadLine();

                }
            }
            for (int i = 0; i < id.Count; i++)
            {
                if (id[i] > Max)
                {
                    Max = id[i];

                }
            }
            return Max;
        }
    }
}
