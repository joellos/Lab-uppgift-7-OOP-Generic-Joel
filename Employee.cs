using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_uppgift_7_OOP_Generic_Joel
{
    public class Employee
    {
        public Employee(string id, string name, string gender, decimal salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}";
        }
    }
}
