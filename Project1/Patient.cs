using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Patient
    {
        public int id;
        public string name; /*= "Nick";*/
        public string surname; /*= "Boyar";*/
        public uint age; /*= 27;*/

        public string diagnos; /*= "All good";*/

        public Patient(int id, string name, string surname, uint age, string diagnos)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.diagnos = diagnos;
        }

        public string GetDiagnos(string diagnos)
        {
            this.diagnos = diagnos;
            return diagnos;
            
        }

        public string GetInfoPatient() 
        {
            return $"Patient name: {name}\n Patient surname: {surname}\n Age: {age}\n Diagnos: {diagnos}";
        }


    }
}
