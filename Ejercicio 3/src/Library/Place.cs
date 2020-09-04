using System;

namespace Library
{
    public class Place
    {
        public string Name { get; set; }

        public Place (string name)
        {
            this.Name = name;
        }
        public Boolean isValid()
        {
            Boolean isValid = string.IsNullOrEmpty(this.Name);
            return isValid;
        }
    }
}