using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Win.Doctors_Clasess
{
  public  class Doctors
    {

      int Au_id()
      {
          int Max = 0;
          StreamReader sr = new StreamReader("Doctor.txt");
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

        public Doctors(){}
         public Doctors (string name, string location, DateTime birth,double sal)

        {

            this.doctor_name = name;
            this.doctor_location = location;
            this.doctor_birth = birth;
            this.doctor_Id = Au_id() + 1;
            this.doctor_sal = sal;  

        }

    

         public string doctor_name { get; set; }

         public string doctor_location { get; set; }

         public DateTime doctor_birth { get; set; }

         public int doctor_Id { get; set; }

         public double doctor_sal { get; set; }



         
    }
}
