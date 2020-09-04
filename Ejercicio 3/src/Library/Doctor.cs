using System;

namespace Library
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Especializacion { get; set; }

        public Doctor (string name, string especializacion)
        {
            this.Name = name;
            this.Especializacion = especializacion;
        }
        public Boolean isValid()
        {
            Boolean isValid = string.IsNullOrEmpty(this.Name) && string.IsNullOrEmpty(this.Especializacion);
            return isValid;
        }
    }
}