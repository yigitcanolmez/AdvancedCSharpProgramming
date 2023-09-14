using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OOP
{
    public class Encapsulation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Identity { get; set; }
        private double Salary { get; set; }

        public void SetPersonSalary(double value)
        {
            if (value > 11000)
                Salary = value;
            else
                throw new Exception("Salary can not be lower than 11.000!");
        }

        public double GetSalary() { return Salary; }

    }
}
