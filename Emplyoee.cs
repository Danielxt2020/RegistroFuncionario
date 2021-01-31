using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace RegistroFuncionario
{
    class Emplyoee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Emplyoee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double porcentage)
        {
            Salary += (Salary * porcentage / 100.00);
        }

        public override string ToString()
        {
            return Id + "," + Name + "," + Salary.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
