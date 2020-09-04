using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Steven Jhonson", "23", "986782342", "5555-555-555");
            Doctor doctor1 = new Doctor ("Dr. Jefferson", "Cardiologist");
            Place place1 = new Place("Brooklyn Clinic");

            string appointmentResult1 = AppointmentService.CreateAppointment(patient1, doctor1, place1);
            Console.WriteLine(appointmentResult1);
        }
    }
}
