namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Patient patient1 = new Patient(1, "Vica", "Mur", 19, "Everything fine");

            Clinic hospital = new Clinic();

            hospital.CreatePatient(patient1);
            Console.WriteLine(hospital.ToString());

            hospital.Update(patient1, "high pulse");
            
            Console.WriteLine(hospital.ToString());


        

 

        }
    }
}