using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Armand", "Medic");
            Doctor doctor2 = new Doctor("Susan", "Medic");

            Patient patient1 = new Patient("Steven Jhonson", 30, "986782342", "5555-555-555");
            Patient patient2 = new Patient("Ralf Manson", 20, "", "5555-555-555");
            
            AppointmentService appointment1 = new AppointmentService(patient1, DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(appointment1.ToText());

            AppointmentService appointment2 = new AppointmentService(patient2, DateTime.Now, "Queen Street", doctor2);
            Console.WriteLine(appointment2.ToText());
        }
    }
}
