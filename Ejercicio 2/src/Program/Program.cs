using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentService appointment1 = new AppointmentService("Steven Jhonson", 30, "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand", "Medic");
            Console.WriteLine(appointment1.ToText());

            AppointmentService appointment2 = new AppointmentService("Ralf Manson", 20, "", "5555-555-555", DateTime.Now, "Queen Street", "", "Medic");
            Console.WriteLine(appointment2.ToText());
        }
    }
}
