using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(Patient patient, Doctor doctor, Place place)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;


            if (patient.isValid())
            {
                stringBuilder.Append("Unable to schedule appointment, Patient not valid\n");
                isValid = false;
            }

            if (doctor.isValid())
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor not valid\n");
                isValid = false;
            }

            if (place.isValid())
            {
                stringBuilder.Append("Unable to schedule appointment, Place name not valid\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
