using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProposto
{
    class Emplyoee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; private set; }

        public Emplyoee(int id, string name, double salary){
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary;
        }
    }
}
