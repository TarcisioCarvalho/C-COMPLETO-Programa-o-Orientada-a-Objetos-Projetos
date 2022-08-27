using Capitulo9.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department = new Department();
        public List<HourContract> hourContracts = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, string department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department.Name = department;
        }

        public void addContract (HourContract contract)
            {
                hourContracts.Add(contract);
            }
        public void removeContract(HourContract contract)
        {
            hourContracts.Remove(contract);
        }

        public double income(int year, int month)
        {
            List<HourContract> contractsPerDate = hourContracts.FindAll(x => x.Date.Month == month && x.Date.Year == year);
            double totalValue = 0;

            foreach (HourContract contract in contractsPerDate)
            {
                totalValue += contract.totalValue();
            }

            return totalValue + BaseSalary;
        }


        public override string ToString()
        {
            return $"Name : {Name} \n  Department: {Department.Name} \n ";
        }
    }
}
