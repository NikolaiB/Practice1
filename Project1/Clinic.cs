using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Clinic
    {
        public List<Patient> patients = new List<Patient>();


        public void CreatePatient(Patient patient)
        {
            patients.Add(patient);

        }

        public void Update(Patient patient, string diagnos)
        {
            foreach (Patient i in patients)
            {
              if (patient == i)      

              {
                    i.GetDiagnos(diagnos);
              }

            }
        }

        public void Delete(Patient patient)
        {
            patients.Remove(patient);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (Patient i in patients)
            {
                sb.AppendLine(i.GetInfoPatient());
            }
            return sb.ToString();
        }
      

    }
}
