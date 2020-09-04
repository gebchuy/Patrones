using System;

namespace Library
{
    public class Patient
    {
        public string Name { get; set; }
        public string Edad { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set; }

        public Patient(string name, string edad, string id, string phoneNumber)
        {
            this.Name = name;
            this.Edad = edad;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }

        public Boolean isValid()
        {
            Boolean isValid = string.IsNullOrEmpty(this.Name) && string.IsNullOrEmpty(this.Edad) && string.IsNullOrEmpty(this.Id) && string.IsNullOrEmpty(this.PhoneNumber);
            return isValid;
        }

    }
}
