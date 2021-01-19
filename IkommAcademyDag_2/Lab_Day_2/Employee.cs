using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    class Employee
    {
        private string employeeName;
        private double salary;
        private DateTime joinDate;
        private string[] skills;
        private int index = 0;

        public string EmployeeName {
            get { return employeeName; }
            private set { employeeName = value;  }
            }

        public double Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        public DateTime JoinDate
        {
            get { return joinDate; }
            private set { joinDate = value; }
        }

        public string[] Skills
        {
            get { return skills; }
            private set { skills = value; }
        }

        public Employee(string name, double salary, DateTime joindate)
        {
            EmployeeName = name;
            Salary = salary;
            JoinDate = joindate;
        }
        public Employee(string name, double salary)
        {
            EmployeeName = name;
            Salary = salary;
            JoinDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $" {EmployeeName} {Salary} {JoinDate.ToShortDateString()} {Skills}";
        }

        public bool Raise(double amount)
        {
            // Possibility to add logic to ensure salary is updated properly and return a exit code. 
            Salary += amount;
            return true;
        }

        public bool AddSkill(string skill)
        {
            if (Skills.Length >= index) return false;
            Skills[index] = skill;
            return true;
        }


    }
}
