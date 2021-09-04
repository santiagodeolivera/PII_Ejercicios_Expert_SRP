using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class AppointmentService
    {

        // Es más conveniente que una instancia de AppointmentService almacene la información, y tenga un método para devolver el texto
        public readonly string Name;
        public readonly byte Age;
        public readonly string Id;
        public readonly string PhoneNumber;
        public readonly DateTime Date;
        public readonly string Place;
        public readonly string DoctorName;
        public readonly string DoctorSpecialty;

        private static List<string> ids = new List<string>();

        public AppointmentService(string name, byte age, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName, string doctorSpecialty)
        {
            // ID validation (ids can't be empty)
            if(id.Length == 0) throw new ArgumentException("Ids can't be empty");
            // ID validation (ids must be different from one another)
            if(ids.Contains(id)) throw new ArgumentException($"There's already an appointment with the id \"{id}\"");

            // Phone number validation (it has to have 10 digits)
            if(phoneNumber.Where(c => Char.IsDigit(c)).Count() != 10)
                throw new ArgumentException($"A phone number must have 10 digits");

            this.Name = name;
            this.Age = age;
            this.Id = id;
            ids.Add(id);
            this.PhoneNumber = phoneNumber;
            this.Date = date;
            this.Place = appointmentPlace;
            this.DoctorName = doctorName;
            this.DoctorSpecialty = doctorSpecialty;
        }

        public string ToText()
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(this.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.Id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.Place))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(this.DoctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appointment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
