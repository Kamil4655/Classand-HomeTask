using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasasasasa.Models
{
    internal class Student
    {
        private int _id;
        private static int count;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public Student(string name, string surname)
        {
            Surname = Captalize(surname);
            Name = Captalize(name);
            _id = count++;
        }

        public string GetInfo()
        {
            return $"{Name},{Surname}";
        }
        public string Captalize(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Valid name");
            }
            return name.First().ToString().ToUpper() + name.Substring(1).ToLower();
        }
    }
}