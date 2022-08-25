using System;
using System.Collections.Generic;


namespace Capitulo6
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }


        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary}";
        }
    }
}
