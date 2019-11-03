using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Win.Doctors_Clasess
{
   public class Retired_Doctor:Doctors
    {
        int Au_id()
      {
          int Max = 0;
          StreamReader sr = new StreamReader("Ret_Doc.txt");
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

        public Retired_Doctor(){}
         public Retired_Doctor  (string name, string location, DateTime birth,double sal)

        {

            this.doctor_name = name;
            this.doctor_location = location;
            this.doctor_birth = birth;
            this.doctor_Id = Au_id() + 1;
            this.doctor_sal = sal;  

        }

    }
}
