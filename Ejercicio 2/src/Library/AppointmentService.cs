using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class AppointmentService
    {

        // Es más conveniente que una instancia de AppointmentService almacene la
        // información, y tenga un método para devolver el texto.

        // La información sobre el paciente de la cita pasa a una clase `Patient`,
        // dado que no está intrínsecamente asociada a la cita.

        // Lo mismo con la información sobre el doctor.

        public readonly Patient PatientData;
        public readonly DateTime Date;
        public readonly string Place;
        public readonly Doctor DoctorData;

        public AppointmentService(Patient patientData, DateTime date, string appointmentPlace, Doctor doctorData)
        {
            if(patientData == null) throw new ArgumentException("Patient data is required");
            if(string.IsNullOrEmpty(appointmentPlace)) throw new ArgumentException("Appointment place is required");
            if(doctorData == null) throw new ArgumentException("Doctor data is required");
            
            this.PatientData = patientData;
            this.Date = date;
            this.Place = appointmentPlace;
            this.DoctorData = doctorData;
        }

        public string ToText()
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if(this.PatientData == null)
            {
                stringBuilder.Append("Unable to schedule appointment, Patient data is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.Place))
            {
                stringBuilder.Append("Unable to schedule appointment, Appointment place is required\n");
                isValid = false;
            }

            
            if (this.DoctorData == null)
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor data is required\n");
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
